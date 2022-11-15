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
        public bool voir;
        public float tour;
        public bool attente;
        public bool valide;
        public toucheJoueur touchej;
        public int actionOnTime;
            // Start is called before the first frame update
        void Start()
        {
            delai = 0.3f;
            limit = 2;
            tour = 0;
            attente = false;
            valide = true;
            for (int i = 0; i < limit; i++)
            {
                choix = Random.Range(1, 5);
                Simon.Add(choix);
                print(Simon);
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
            if(timeo >= delai)
            {
                if(actionOnTime == 0 && nombre < 4 && valide == true)
                {
                    AllumerLumiere();
                }
                if(actionOnTime == 2 && nombre < 4 && valide == true)
                {
                    EteindreLumiere();
                }
                timeo = 0;
                actionOnTime++;
                if (actionOnTime >= 3 && valide == true)
                {
                    actionOnTime = 0;
                    tour += 1;
                    nombre += 1;
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

        }
        void verif()
        {
            if (attente == true)
            {
                for (int i = 0; i < limit; i++)
                {
                    if (touchej.valeurs[i] == Simon[i]) { valide = false; attente = false; }
                }
            }
        }
        void AllumerLumiere()
        {
            if (Simon[nombre] == 1)
            {
                LFlecheH.enabled = true;
                voir = true;
                print("1");
            }
            if (Simon[nombre] == 2)
            {
                LFlecheB.enabled = true;
                voir = true;
                print("2");
            }
            if (Simon[nombre] == 3)
            {
                LFlecheD.enabled = true;
                voir = true;
                print("3");
            }
            if (Simon[nombre] == 4)
            {
                LFlecheG.enabled = true;
                voir = true;
                print("4");
            }
            
        }
        void EteindreLumiere()
        {
            if (Simon[nombre] == 1)
            {
                LFlecheH.enabled = false;
                voir = false;
                print("haut");
            }
            if (Simon[nombre] == 2)
            {
                LFlecheB.enabled = false;
                voir = false;
                print("bas");
            }
            if (Simon[nombre] == 3)
            {
                LFlecheD.enabled = false;
                voir = false;
                print("droite");
            }
            if (Simon[nombre] == 4)
            {
                LFlecheG.enabled = false;
                voir = false;
                print("gauche");
            }

        }
    }

}
