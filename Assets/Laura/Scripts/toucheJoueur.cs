using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class toucheJoueur : MonoBehaviour
    {
        public MeshRenderer FH,FB,FD,FG;
        public List<int> valeurs;
        private bool inputEntered = false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void FlecheH()
        {
            if(inputEntered == false)
            {
                inputEntered = true;
                FH.materials[1].color = Color.red;
                valeurs.Add(1);
                Debug.Log("Rouge");
            }
        }
        public void FlecheD()
        {
            if (inputEntered == false)
            {
                inputEntered = true;

                FD.materials[1].color = Color.green;
                valeurs.Add(3);
                Debug.Log("Vert");
            }
        }
        public void FlecheB()
        {
            if (inputEntered == false)
            {
                inputEntered = true;

                FB.materials[1].color = Color.yellow;
                valeurs.Add(2);
                Debug.Log("Jaune");
            }
        }
        public void FlecheG()
        {
            if (inputEntered == false)
            {
                inputEntered = true;

                FG.materials[1].color = Color.blue;
                valeurs.Add(4);
                Debug.Log("Bleu");
            }
        }

        public void ResetColor()
        {
            inputEntered = false;

            FG.materials[1].color = Color.white;
            FD.materials[1].color = Color.white;
            FH.materials[1].color = Color.white;
            FB.materials[1].color = Color.white;
        }
    }


}
