using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class Movement3D : MonoBehaviour
    {
        //********* Init des variables *****************
        private float speed = 0.13f;
        public Transform TF;
        // *********************************************
        void Start()
        {
            {

            }
        }

        //*************** Pour chaque frame *******************************
        void Update()
        {
            VerifAssiettePosition();
        }
        // ************************************************************
        //************Fonction de mouvement***************************
        public void RightMove(){
            TF.localPosition += TF.right * speed;
        }
        
        public void LeftMove(){
            TF.localPosition += TF.right * -speed;
        }
         // ************************************************************
        //******************Verifie la position de l'assiette*************************
        public void VerifAssiettePosition(){
            if (TF.position.x > 9.48)
            {
                TF.position = new Vector3(-9f,0.52f,-6.8f);         // si position egale a X alors tp l'assiette a X coo
            }
            if (TF.position.x < -9.48)
            {
                TF.position = new Vector3(9f, 0.52f, -6.8f);
            }
        }
        // ************************************************************
    }
    
}