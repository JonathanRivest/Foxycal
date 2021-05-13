using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*****************************************************************************************************
 * STATUS: Fini
 * Auteur: Andy
 * Description: Script qui g�re la consommation d'un fruit du personage
 * Derni�re modification: 27 avril 2021
 ****************************************************************************************************/

public class ConsommerFruit : MonoBehaviour
{
    public void consommerFruit()
    {
        GetComponent<Image>().enabled = false;
        Destroy(gameObject, 0.25f);
        gestionFaimPersonnage.faim += 10f;
        GetComponent<AudioSource>().Play();
    }
}
