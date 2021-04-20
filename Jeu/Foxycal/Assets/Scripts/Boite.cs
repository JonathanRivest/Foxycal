using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boite : MonoBehaviour
{
    private GestionInventaire inventaire;
    public int i;

    void Start()
    {
        inventaire = GameObject.FindGameObjectWithTag("Player").GetComponent<GestionInventaire>();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventaire.rempli[i] = false;
        }
    }

    public void detruireEnfant()
    {
        foreach (Transform child in transform)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
