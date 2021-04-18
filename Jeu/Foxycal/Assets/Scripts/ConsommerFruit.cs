using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*****************************************************************************************************
 * STATUS: En progr�s... Quelques Bugs a regler
 * Auteur: Andy
 * Description: Script qui g�re la consommation d'un fruit du personage
 * Derni�re modification: 15 avril 2021
 ****************************************************************************************************/

public class ConsommerFruit : MonoBehaviour
{

    // Si le personnage a un objet dans l'inventaire, �a disparait et ajuste la barre de faim
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && GetComponent<GestionInventaire>().rempli[0] == true)
        {
            GetComponent<GestionInventaire>().rempli[0] = false;
            // GetComponent<barreDeFaimScript>().sliderFaim.value = 10f;
            // Destroy(GetComponent<RamasserFruit>().fruit);
        }
    }
}