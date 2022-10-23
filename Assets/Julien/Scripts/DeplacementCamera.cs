using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class DeplacementCamera : MonoBehaviour
    {

        public int chrono = 10000;
        public float vitesseCamera = 0.000000003f;

        // Start is called before the first frame update
        void Start()
        {

        }

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
                Debug.Log("Gagné !");
            }
        }
    }
}
