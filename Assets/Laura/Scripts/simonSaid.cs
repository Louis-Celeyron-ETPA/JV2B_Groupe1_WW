using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{
    public class simonSaid : MonoBehaviour
    {
        public GameObject FlecheH;
        public GameObject FlecheB;
        public GameObject FlecheD;
        public GameObject FlecheG;
        public Light LFlecheH;
        public Light LFlecheB;
        public Light LFlecheD;
        public Light LFlecheG;
        public List<int> Simon;
        private int choix;
        private int limit;
        public float timeo;
        public float delai;
        public int nombre = 0;
        public float tour;
        public bool attente;
        public bool valide;
        public toucheJoueur lista;
        public int actionOnTime;
            // Start is called before the first frame update
        void Start()
        {
            delai = 1f;
            limit = 2;
            tour = 0;
            attente = false;
            valide = true;
            for (int i = 0; i < limit; i++)
            {
                choix = Random.Range(1, 5);
                Simon.Add(choix);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (tour <= 3 && limit < 4)
            {
                if (tour == 2 && nombre == limit && attente == true) 
                { limit = 3;
                  choix = Random.Range(1, 5);
                  Simon.Add(choix);
                }
                if (tour == 3 && nombre == limit && attente == true) 
                { limit = 4;
                  choix = Random.Range(1, 5);
                  Simon.Add(choix);
                }
            }

            timeo += Time.deltaTime;
            if (timeo >= delai)
            {
                if (actionOnTime == 0 && valide == true)
                {
                    AllumerLumiere();
                }
                if (actionOnTime == 1 && valide == true)
                {
                    EteindreLumiere();
                    nombre += 1;
                    tour += 1;
                }
                timeo = 0;
                actionOnTime += 1;
            }
            
            if (actionOnTime == 2 && valide == true)
            {
                actionOnTime = 0;
                if (tour == 2)
                {
                    attente = true;
                    verif();
                }
                if (tour == 3)
                {
                    attente = true;
                    verif();
                }
            }
        }
        public void verif()
        {
            valide = false;
            if (attente == true)
            {
                for (int i = 0; i < limit; i++)
                {
                    if (lista.valeurs[i] == Simon[i]) { valide = true; attente = false; nombre = 0; }
                }
            }
        }
        void AllumerLumiere()
        {
            if (Simon[nombre] == 1)
            {
                LFlecheH.enabled = true;
                Debug.Log("1");
            }
            if (Simon[nombre] == 2)
            {
                LFlecheB.enabled = true;
                Debug.Log("2");
            }
            if (Simon[nombre] == 3)
            {
                LFlecheD.enabled = true;
                Debug.Log("3");
            }
            if (Simon[nombre] == 4)
            {
                LFlecheG.enabled = true;
                Debug.Log("4");
            }
            
        }
        void EteindreLumiere()
        {
            if (Simon[nombre] == 1)
            {
                LFlecheH.enabled = false;
                Debug.Log("haut");
            }
            if (Simon[nombre] == 2)
            {
                LFlecheB.enabled = false;
                Debug.Log("bas");
            }
            if (Simon[nombre] == 3)
            {
                LFlecheD.enabled = false;
                Debug.Log("droite");
            }
            if (Simon[nombre] == 4)
            {
                LFlecheG.enabled = false;
                Debug.Log("gauche");
            }

        }
    }

}
