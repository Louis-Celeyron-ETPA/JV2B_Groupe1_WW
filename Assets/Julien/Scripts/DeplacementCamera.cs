using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class DeplacementCamera : MonoBehaviour
    {

        //************************************ INITIATION DES VARIABLES ************************************
        public int chrono = 1050;
        public float vitesseCamera = 0.002f;

        // Start is called before the first frame update
        void Start()
        {

        }


        //************************************ MISE EN PLACE DU CHRONOMETRE ************************************
        // Update is called once per frame
        void Update()
        {
            if (chrono > 1)
            {
                chrono--;
                transform.Translate(-Vector3.left * vitesseCamera);
            }
            else
            {
                chrono = 0;
                Debug.Log("Gagn� !");
            }
        }
    }
}
