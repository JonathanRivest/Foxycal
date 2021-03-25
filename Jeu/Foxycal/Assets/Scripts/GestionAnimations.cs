﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionAnimations : MonoBehaviour
{
    // Liste des touches (Inutilisée)
    List<List<bool>> ListeTouches;

    // WASD
    bool W;
    bool A;
    bool S;
    bool D;

    // Flèches
    bool Up;
    bool Left;
    bool Down;
    bool Right;

    // Attaques
    bool E;
    bool R;
    bool T;

    // Souris
    bool LMC;
    bool RMC;

    // Liste des actions
    bool action;
    bool attaque;
    bool pouvoir;
    bool manger;



    void Update()
    {
        /***********/
        /* TOUCHES */
        /***********/

        // Liste des touches
        List<bool> ListeTouches = new List<bool>()
        { W, A, S, D, Up, Left, Down, Right, E, R, T, LMC, RMC };

        // Touches WASD
        W = Input.GetKey(KeyCode.W);
        A = Input.GetKey(KeyCode.A);
        S = Input.GetKey(KeyCode.S);
        D = Input.GetKey(KeyCode.D);

        // Touches Flèchées
        Up    = Input.GetKey(KeyCode.UpArrow);
        Left  = Input.GetKey(KeyCode.LeftArrow);
        Down  = Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.RightArrow);

        // Touches Pouvoirs
        E = Input.GetKey(KeyCode.E);
        R = Input.GetKey(KeyCode.R);
        T = Input.GetKey(KeyCode.T);

        // Touche Attaque
        LMC = Input.GetKey(KeyCode.Mouse0);

        // Touche Manger
        RMC = Input.GetKey(KeyCode.Mouse1);


        // Animation de marche
        if      (W || Up)    GetComponent<Animator>().SetBool("Marche", true);
        else if (A || Left)  GetComponent<Animator>().SetBool("Marche", true);
        else if (S || Down)  GetComponent<Animator>().SetBool("Marche", true);
        else if (D || Right) GetComponent<Animator>().SetBool("Marche", true);
        else                 GetComponent<Animator>().SetBool("Marche", false);


        // Si l'on touche n'importe quelle touche du clavier ET que le renard n'agit pas,
        if (Input.anyKeyDown && !action)
        {
            // Si une attaque n'est pas en cours,
            if (!attaque)
            {
                // Touche des attaques
                if (LMC) StartCoroutine(GestionAttaques("LMC"));
            }

            // Si le renard n'est pas en train de manger,
            if (!manger)
            {
                // Touche pour manger
                if (RMC) StartCoroutine(GestionAttaques("RMC"));
            }

            // Si un pouvoir n'est pas activé,
            if (!pouvoir)
            {
                // Touches des pouvoirs
                if (E) StartCoroutine(GestionAttaques("E"));
                if (R) StartCoroutine(GestionAttaques("R"));
                if (T) StartCoroutine(GestionAttaques("T"));
            }
        }
    }


    IEnumerator GestionAttaques(string Animation)
    {
        // Le renard agit
        action = true;

        switch (Animation)
        {
            /************/
            /* ATTAQUES */
            /************/

            case "LMC":

                // Le renard attaque
                attaque = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation d'attaque Gauche
                GetComponent<Animator>().SetTrigger("Attaque_L");

                // Attendre 1 seconde
                yield return new WaitForSeconds(1f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Le renard n'agit plus
                attaque = false;

                // Le renard n'agit plus
                action = false;

                break;



            /**********/
            /* MANGER */
            /**********/

            case "RMC":

                // Le renard mange
                manger = true;

                // Activer l'animation de manger
                GetComponent<Animator>().SetBool("Mange", true);

                // Attendre 3 secondes
                yield return new WaitForSeconds(3f);

                // Désactiver l'animation de manger
                GetComponent<Animator>().SetBool("Mange", false);

                // Le renard n'agit plus
                manger = false;

                // Le renard n'agit plus
                action = false;

                break;




            /************/
            /* POUVOIRS */
            /************/

            case "E":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 4.25 secondes
                yield return new WaitForSeconds(4.25f);

                // Le renard n'agit plus
                pouvoir = false;

                break;


            case "R":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 7.25 secondes
                yield return new WaitForSeconds(7.25f);

                // Le renard n'agit plus
                pouvoir = false;

                break;


            case "T":

                // Le renard envoie un pouvoir
                pouvoir = true;

                // Activer l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", true);

                // Activer l'animation de pouvoir
                GetComponent<Animator>().SetTrigger("Pouvoir_Trigger");

                // Attendre 0.75 secondes
                yield return new WaitForSeconds(0.75f);

                // Désactiver l'animation d'attaque
                GetComponent<Animator>().SetBool("Attaque", false);

                // Désactiver l'animation de pouvoir
                GetComponent<Animator>().SetBool("Pouvoir_Bool", false);

                // Le renard n'agit plus
                action = false;

                // Attendre 12.25 secondes
                yield return new WaitForSeconds(12.25f);

                // Le renard n'agit plus
                pouvoir = false;

                break;
        }
    }
}