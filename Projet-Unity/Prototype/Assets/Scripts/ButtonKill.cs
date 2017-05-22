using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonKill : MonoBehaviour {

    public Button Kill;

    // Use this for initialization
    void Start () {
        Button btn = Kill.GetComponent<Button>();
        btn.onClick.AddListener(ActionKill);
    }
	void ActionKill()
    {
        SendMessage("DieClicked");
    }
	// Update is called once per frame
	void Update () {
	
	}
}
