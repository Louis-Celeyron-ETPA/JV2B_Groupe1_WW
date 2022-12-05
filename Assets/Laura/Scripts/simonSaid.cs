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
        public MeshRenderer barre;
        public MeshRenderer p1;
        public MeshRenderer p2;
        public MeshRenderer p3;
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
        public int points;
            // Start is called before the first frame update
        void Start()
        {
            delai = 0.3f;
            limit = 4;
            tour = 2;
            points = 0;
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
            if(nombre<tour)
            {
                GestionLumiere();
                barre.materials[2].color = Color.red;
            }
            else
            {
                attente = true;
                barre.materials[2].color = Color.green;
            }
            if (points == 1)
            {
                p1.materials[2].color = Color.green;
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (points == 2)
            {
                p2.materials[2].color = Color.green;
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (points == 3)
            {
                p3.materials[2].color = Color.green;
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }

        }
        public void verif()
        {
            if (lista.valeurs.Count != tour)
            {
                return;
            }
            valide = false;
            if (attente == true)
            {
                var tempIsOkay = true;
                for (int i = 0; i < tour; i++)
                {
                    
                    if (lista.valeurs[i] != Simon[i])
                    {
                        tempIsOkay = false;
                    }
                }
                if (tempIsOkay == true)
                {
                    barre.materials[2].color = Color.red;
                    valide = true;
                    attente = false;
                    nombre = 0;
                    points++;
                    lista.valeurs = new List<int>();
                    tour++;
                }
                else
                {
                    barre.materials[2].color = Color.red;
                    nombre = 0;
                    valide = true;
                    attente = false;
                    lista.valeurs = new List<int>();
                    GestionLumiere();
                }
            }
        }
        private void GestionLumiere()
        {
            timeo += Time.deltaTime;
            if (timeo >= delai && valide == true)
            {
                if (actionOnTime == 0)
                {
                    AllumerLumiere();
                }
                if (actionOnTime == 1)
                {
                    EteindreLumiere();
                    nombre += 1;
                }
                if (actionOnTime == 2)
                {
                    actionOnTime = -1;
                }
                actionOnTime += 1;
                timeo = 0;
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
