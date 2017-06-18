using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {



    public Text sauvesText;
    public Text vivantText;

    void Awake()
    {
        variables.nbrVivant = constantes.NBRVIVANT;
        variables.nbrSauves = constantes.NBRSAUVES;
        setSauvesText();
        setVivantText();
    }

   public void Death()
    {
        if (variables.nbrVivant > 0)
        {
            --variables.nbrVivant;
            setVivantText();
        }
        else
            print("Vous avez perdu !");
    }

    void Save()
    {
        ++variables.nbrSauves;
        setSauvesText();
        if (variables.nbrVivant > 0)
        {
            --variables.nbrVivant;
            setVivantText();
        }
        else
            print("Niveau Terminé !");
    }

    void setVivantText()
    {
        vivantText.text = "Vivants : " + variables.nbrVivant.ToString();
    }

    void setSauvesText()
    {
        sauvesText.text = "Sauvés : " + variables.nbrSauves.ToString();
    }
}