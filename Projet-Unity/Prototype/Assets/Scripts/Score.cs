using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

<<<<<<< HEAD

=======
    private int nbrVivant;
    private int nbrSauves;
>>>>>>> refs/remotes/origin/Vincent_LAURENT

    public Text sauvesText;
    public Text vivantText;

    void Awake()
    {
<<<<<<< HEAD
        variables.nbrVivant = constantes.NBRVIVANT;
        variables.nbrSauves = constantes.NBRSAUVES;
=======
        nbrVivant = constantes.NBRVIVANT;
        nbrSauves = constantes.NBRSAUVES;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
        setSauvesText();
        setVivantText();
    }

<<<<<<< HEAD
   public void Death()
    {
        if (variables.nbrVivant > 0)
        {
            --variables.nbrVivant;
=======
    void Death()
    {
        if (nbrVivant > 0)
        {
            --nbrVivant;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
            setVivantText();
        }
        else
            print("Vous avez perdu !");
    }

    void Save()
    {
<<<<<<< HEAD
        ++variables.nbrSauves;
        setSauvesText();
        if (variables.nbrVivant > 0)
        {
            --variables.nbrVivant;
=======
        ++nbrSauves;
        setSauvesText();
        if (nbrVivant > 0)
        {
            --nbrVivant;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
            setVivantText();
        }
        else
            print("Niveau Terminé !");
    }

    void setVivantText()
    {
<<<<<<< HEAD
        vivantText.text = "Vivants : " + variables.nbrVivant.ToString();
=======
        vivantText.text = "Vivants : " + nbrVivant.ToString();
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    void setSauvesText()
    {
<<<<<<< HEAD
        sauvesText.text = "Sauvés : " + variables.nbrSauves.ToString();
=======
        sauvesText.text = "Sauvés : " + nbrSauves.ToString();
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }
}