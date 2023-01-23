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
        public MeshRenderer Barre;
        public MeshRenderer P1;
        public MeshRenderer P2;
        public MeshRenderer P3;
        private int Choix;
        private int Limite=4;
        public float TempO;
        public float Delai;
        public int Nombre = 0;
        public float Tour;
        public bool Attente;
        public bool Valide;
        public toucheJoueur ListA;
        public int ActionEnTemps;
        public int Points;
            
        void Start()
        {
            Nombre = 0;
            Delai = 0.3f;
            Tour = 2;
            Points = 0;
            Attente = false;
            Valide = true;
            for (int i = 0; i < Limite; i++)
            {
                Choix = Random.Range(1, 5);
                Simon.Add(Choix);
            }
        }

        
        void Update()
        {
            if(Nombre<Tour)
            {
                GestionLumiere();
                Barre.materials[2].color = Color.red;
            }
            else
            {
                Attente = true;
                Barre.materials[2].color = Color.green;
            }
            if (Points == 1)
            {
                P1.materials[2].color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (Points == 2)
            {
                P2.materials[2].color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (Points == 3)
            {
                P3.materials[2].color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }

        }
        public void verif()
        {
            if (ListA.Valeurs.Count != Tour)
            {
                return;
            }
            Valide = false;
            if (Attente == true)
            {
                var tempIsOkay = true;
                for (int i = 0; i < Tour; i++)
                {
                    
                    if (ListA.Valeurs[i] != Simon[i])
                    {
                        tempIsOkay = false;
                    }
                }
                if (tempIsOkay == true)
                {
                    Barre.materials[2].color = Color.red;
                    Valide = true;
                    Attente = false;
                    Nombre = 0;
                    Points++;
                    ListA.Valeurs = new List<int>();
                    Tour++;
                }
                else
                {
                    Barre.materials[2].color = Color.red;
                    Nombre = 0;
                    Valide = true;
                    Attente = false;
                    ListA.Valeurs = new List<int>();
                    GestionLumiere();
                }
            }
        }
        private void GestionLumiere()
        {
            TempO += Time.deltaTime;
            if (TempO >= Delai && Valide == true)
            {
                if (ActionEnTemps == 0)
                {
                    AllumerLumiere();
                }
                if (ActionEnTemps == 1)
                {
                    EteindreLumiere();
                    Nombre += 1;
                }
                if (ActionEnTemps == 2)
                {
                    ActionEnTemps = -1;
                }
                ActionEnTemps += 1;
                TempO = 0;
            }
        }
        void AllumerLumiere()
        {
            if (Simon[Nombre] == 1)
            {
                LFlecheH.enabled = true;
                Debug.Log("1");
            }
            if (Simon[Nombre] == 2)
            {
                LFlecheB.enabled = true;
                Debug.Log("2");
            }
            if (Simon[Nombre] == 3)
            {
                LFlecheD.enabled = true;
                Debug.Log("3");
            }
            if (Simon[Nombre] == 4)
            {
                LFlecheG.enabled = true;
                Debug.Log("4");
            }
            
        }
        void EteindreLumiere()
        {
            if (Simon[Nombre] == 1)
            {
                LFlecheH.enabled = false;
                Debug.Log("haut");
            }
            if (Simon[Nombre] == 2)
            {
                LFlecheB.enabled = false;
                Debug.Log("bas");
            }
            if (Simon[Nombre] == 3)
            {
                LFlecheD.enabled = false;
                Debug.Log("droite");
            }
            if (Simon[Nombre] == 4)
            {
                LFlecheG.enabled = false;
                Debug.Log("gauche");
            }

        }
    }

}
