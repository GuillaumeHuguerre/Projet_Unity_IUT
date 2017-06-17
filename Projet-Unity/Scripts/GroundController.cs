using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	private SpriteRenderer sr;
	private float widthWorld, heightWorld;
	private int widthPixel, heightPixel;
	private Color transp; 

	// Start() GroundController
	void Start(){
        //définition du sprite
		sr = GetComponent<SpriteRenderer>(); 
		Texture2D tex = (Texture2D) Resources.Load("teste1");
		Texture2D tex_clone = (Texture2D) Instantiate(tex);
 
		sr.sprite = Sprite.Create(tex_clone, 
		                          new Rect(0f, 0f, tex_clone.width, tex_clone.height),
		                          new Vector2(0.5f, 0.5f), 100f);
		transp = new Color(0f, 0f, 0f, 0f);
		InitSpriteDimensions();
		DiggerController.groundController = this;
	}

	private void InitSpriteDimensions() {
		widthWorld = sr.bounds.size.x;
		heightWorld = sr.bounds.size.y;
		widthPixel = sr.sprite.texture.width;
		heightPixel = sr.sprite.texture.height;
	}



	public void DestroyGround( CircleCollider2D cc ){

		V2int c = World2Pixel(cc.bounds.center.x, cc.bounds.center.y);
        // c => centre du cercle de destruction

        int r = Mathf.RoundToInt(cc.bounds.size.x*widthPixel/widthWorld);
		// r => rayon du cercle de destruction

		int x, y, px, nx, py, ny, d;
		
		for (x = 0; x <= r; x++)
		{
			d = (int)Mathf.RoundToInt(Mathf.Sqrt(r * r - x * x));
			
            //rend invisible les pixel dans le cercle
			for (y = 0; y <= d; y++)
			{
				px = c.x + x;
				nx = c.x - x;
				py = c.y + y;
				ny = c.y - y;

				sr.sprite.texture.SetPixel(px, py, transp);
				sr.sprite.texture.SetPixel(nx, py, transp);
				sr.sprite.texture.SetPixel(px, ny, transp);
				sr.sprite.texture.SetPixel(nx, ny, transp);
			}
		}
		sr.sprite.texture.Apply();

        //remplace le collider par un nouveau avec les nouvelles formes
		Destroy(GetComponent<PolygonCollider2D>());
		gameObject.AddComponent<PolygonCollider2D>();

	}

	private V2int World2Pixel(float x, float y) {
		V2int v = new V2int();
		
		float dx = x-transform.position.x;
		v.x = Mathf.RoundToInt(0.5f*widthPixel+ dx*widthPixel/widthWorld);
		
		float dy = y - transform.position.y;
		v.y = Mathf.RoundToInt(0.5f * heightPixel + dy * heightPixel / heightWorld);
		
		return v;
	}
}
