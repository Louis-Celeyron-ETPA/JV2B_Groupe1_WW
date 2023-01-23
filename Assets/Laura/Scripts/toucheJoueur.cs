using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class toucheJoueur : MonoBehaviour
    {
        public MeshRenderer FH,FB,FD,FG;
        public List<int> Valeurs;
        private bool BoutonEntrer = false;
        public simonSaid SimonSaid;
        
        public void FlecheH()
        {
            if(BoutonEntrer == false)
            {
                BoutonEntrer = true;
                FH.materials[1].color = Color.red;
                Valeurs.Add(1);
                Debug.Log("Rouge");
            }
        }
        public void FlecheD()
        {
            if (BoutonEntrer == false)
            {
                BoutonEntrer = true;

                FD.materials[1].color = Color.green;
                Valeurs.Add(3);
                Debug.Log("Vert");

            }
        }
        public void FlecheB()
        {
            if (BoutonEntrer == false)
            {
                BoutonEntrer = true;

                FB.materials[1].color = Color.yellow;
                Valeurs.Add(2);
                Debug.Log("Jaune");

            }
        }
        public void FlecheG()
        {
            if (BoutonEntrer == false)
            {
                BoutonEntrer = true;

                FG.materials[1].color = Color.blue;
                Valeurs.Add(4);
                Debug.Log("Bleu");

            }
        }

        public void ResetColor()
        {
            BoutonEntrer = false;

            FG.materials[1].color = Color.white;
            FD.materials[1].color = Color.white;
            FH.materials[1].color = Color.white;
            FB.materials[1].color = Color.white;
            SimonSaid.verif();

        }
    }


}
