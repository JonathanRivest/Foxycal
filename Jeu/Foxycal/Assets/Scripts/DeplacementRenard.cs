using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRenard : MonoBehaviour
{
    public float vitesseTranslation;
    public float vitesseRotation;
    private bool peutAvancer;

    bool W;
    bool A;
    bool S;
    bool D;

    bool Up;
    bool Left;
    bool Down;
    bool Right;


    void Update()
    {
        // Touches WASD
        W = Input.GetKey(KeyCode.W);
        A = Input.GetKey(KeyCode.A);
        S = Input.GetKey(KeyCode.S);
        D = Input.GetKey(KeyCode.D);

        // Touches Fl�ch�es
        Up    = Input.GetKey(KeyCode.UpArrow);
        Left  = Input.GetKey(KeyCode.LeftArrow);
        Down  = Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.RightArrow);


        // Gestion des translations
        if (W || Up)    GererTranslation("Haut");
        if (A || Left)  GererTranslation("Gauche");
        if (S || Down)  GererTranslation("Bas");
        if (D || Right) GererTranslation("Droite");
    }

    void GererTranslation(string dir)
    {
        // Selon la direction,
        switch (dir)
        {
            case "Haut"  : transform.Translate(0, 0, 1);  break;
            case "Gauche": transform.Translate(-1, 0, 0); break;
            case "Bas"   : transform.Translate(0, 0, -1); break;
            case "Droite": transform.Translate(1, 0, 0);  break;
        }
    }
}
