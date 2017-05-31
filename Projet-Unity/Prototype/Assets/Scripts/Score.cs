using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    private int nbrVivant;
    private int nbrSauves;

    public Text sauvesText;
    public Text vivantText;

    void Awake()
    {
        nbrVivant = constantes.NBRVIVANT;
        nbrSauves = constantes.NBRSAUVES;
        setSauvesText();
        setVivantText();
    }

    void Death()
    {
        if (nbrVivant > 0)
        {
            --nbrVivant;
            setVivantText();
        }
        else
            print("Vous avez perdu !");
    }

    void Save()
    {
        ++nbrSauves;
        setSauvesText();
        if (nbrVivant > 0)
        {
            --nbrVivant;
            setVivantText();
        }
        else
            print("Niveau Terminé !");
    }

    void setVivantText()
    {
        vivantText.text = "Vivants : " + nbrVivant.ToString();
    }

    void setSauvesText()
    {
        sauvesText.text = "Sauvés : " + nbrSauves.ToString();
    }
}