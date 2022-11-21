using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class Deplacements : MonoBehaviour
    {
        public int chrono = 7600;
        public float speed = 0.05f;
        public float vitesseBaguette = 0.003f;
        public float sensitivity = 1.5f;
        public KeyCode avance;
        public KeyCode recule;
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
                transform.Translate(-Vector3.up * vitesseBaguette);
            }
            else
            {
                chrono = 0;
                Debug.Log("Gagné !");
            }
        }
        public void FonctionBaguette(int choixBaguette)
        {
            if (choixBaguette == 1)
            {
                transform.localPosition += transform.forward * speed;
            }

            else if (choixBaguette == 2)
            {
                transform.localPosition += transform.forward * -speed;
            }

        }
    }
}
