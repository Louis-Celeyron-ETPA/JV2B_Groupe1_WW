using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class presenterDeroulement : MonoBehaviour
    {
        public int choixDemande;
        private MeshRenderer FlecheHaut;
        private MeshRenderer FlecheBas;
        private MeshRenderer FlecheDroite;
        private MeshRenderer FlecheGauche;


        // Start is called before the first frame update
        void Start()
        {
            FlecheHaut = GetComponent<MeshRenderer>();
            FlecheBas = GetComponent<MeshRenderer>();
            FlecheDroite = GetComponent<MeshRenderer>();
            FlecheGauche = GetComponent<MeshRenderer>();
            FonctionChoix();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void FonctionChoix()
        {
            choixDemande = Random.Range(1, 6);
            Debug.Log(choixDemande);

            if (choixDemande == 1)
            {
                Debug.Log("Appuyer sur le bouton.png");
            }
            else if (choixDemande == 2)
            {
                Debug.Log("Appuyer sur la flèche haut.png");
                FlecheHaut.enabled = false;
            }
            else if (choixDemande == 3)
            {
                Debug.Log("Appuyer sur la flèche bas.png");
                FlecheBas.enabled = false;
            }
            else if (choixDemande == 4)
            {
                Debug.Log("Appuyer sur la flèche droite.png");
                FlecheDroite.enabled = false;
            }
            else if (choixDemande == 5)
            {
                Debug.Log("Appuyer sur la flèche gauche.png");
                FlecheGauche.enabled = false;
            }
        }
        public void FonctionExecution(int choixEntre)
        {
            if (choixDemande == choixEntre)
            {
                Debug.Log("QTE réussi.png");
            }
            else if (choixDemande != choixEntre)
            {
                Debug.Log("-1 vie");
            }
        }

    }
}

