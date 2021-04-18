using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    /// Auteur : Tristan Lapointe
    /// Description : G�re le shake de cam�ra quand c'est la nuit
    /// 
    public IEnumerator Shake (float duree, float magnitude)
    {
        //Position orginale de la cam�ra
        Vector3 positionOriginale = transform.localPosition;

        //Temps �coul�
        float tempsPasse = 0.0f;

        //Pendant que le temps passe (avant la dur�e maximum), calculer des valeurs randoms pour le shake
        while (tempsPasse < duree)
        {
            // Valeurs al�atoires
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            // Shake
            transform.localPosition = new Vector3(x, y, positionOriginale.z);

            // Augmenter le temps �coul� avec les frames delta time
            tempsPasse += Time.deltaTime;

            // Attendre que la prochaine instance de while se passe
            yield return null;
        }

        // Remettre la position originale apr�s le shake
        transform.localPosition = positionOriginale;

    }
}