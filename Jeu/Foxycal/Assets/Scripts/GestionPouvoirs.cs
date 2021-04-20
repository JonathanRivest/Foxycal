using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    /// Auteur : Guillaume V�zina
    /// Description : Active les pouvoirs du personnage

    public GameObject RefPouvoirLMC;
    public GameObject RefPouvoirE;
    public GameObject RefPouvoirT;
    public GameObject RefComete;

    private GameObject ClonePouvoirLMC;
    private GameObject ClonePouvoirE;
    private GameObject ClonePouvoirT;
    private GameObject CloneComete;

    public float vitessePouvoirT;
    public float dureePouvoirT;

    public IEnumerator LancerPouvoir(string Pouvoir)
    {
        // Selon le pouvoir,
        switch (Pouvoir)
        {
            case "LMC":

                // Faire un clone � ce pouvoir
                ClonePouvoirLMC = Instantiate(RefPouvoirLMC);

                // Changer le parent du pouvoir
                ClonePouvoirLMC.transform.parent = RefPouvoirLMC.transform.parent;

                // R��tablir la position du pouvoir
                ClonePouvoirLMC.transform.position = RefPouvoirLMC.transform.position;

                // Changer le nom du clone
                ClonePouvoirLMC.name = "Morsure";

                // Activer le clone
                ClonePouvoirLMC.SetActive(true);

                // D�truire l'objet apr�s 1 seconde
                Destroy(ClonePouvoirLMC, 1f);

                break;


            case "E":

                // Faire un clone � ce pouvoir
                ClonePouvoirE = Instantiate(RefPouvoirE);

                // Changer le parent du pouvoir
                ClonePouvoirE.transform.parent = RefPouvoirE.transform.parent;

                // R��tablir la position du pouvoir
                ClonePouvoirE.transform.position = RefPouvoirE.transform.position;

                // Changer le nom du clone
                ClonePouvoirE.name = "Foudre Mystique";

                // Activer le clone
                ClonePouvoirE.SetActive(true);

                break;


            case "R":

                // Faire un clone � la comete
                CloneComete = Instantiate(RefComete);

                // Changer le parent de la comete
                CloneComete.transform.parent = RefComete.transform.parent;

                // R��tablir la position de la comete
                CloneComete.transform.position = RefComete.transform.position;

                // Changer le nom du clone
                CloneComete.name = "Comete";

                // Activer le clone
                CloneComete.SetActive(true);

                break;


            case "T":

                // Faire un clone � ce pouvoir
                ClonePouvoirT = Instantiate(RefPouvoirT);

                // Changer le parent du pouvoir
                ClonePouvoirT.transform.parent = RefPouvoirT.transform.parent;

                // R��tablir la position du pouvoir
                ClonePouvoirT.transform.position = RefPouvoirT.transform.position;

                // Changer le nom du clone
                ClonePouvoirT.name = "Souffle �lectrique";

                // Activer le clone
                ClonePouvoirT.SetActive(true);

                // Appliquer une v�locit� pour le pouvoir
                ClonePouvoirT.GetComponent<Rigidbody>().velocity = (transform.forward * vitessePouvoirT);

                // Retirer le parent du clone
                ClonePouvoirT.transform.parent = null;

                // D�truire le clone apr�s un certain temps
                Destroy(ClonePouvoirT, dureePouvoirT);

                break;
        }

        yield return null;
    }
}
