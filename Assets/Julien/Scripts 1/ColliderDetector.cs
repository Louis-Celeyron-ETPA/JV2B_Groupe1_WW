using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class ColliderDetector : MonoBehaviour
    {
        public bool EnContact;
        public int chrono = 10000;
        public float speed = 0.002f;
        public float vitesseBaguette = 0.000000003f;
        public KeyCode avance;
        public KeyCode recule;

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Collision detecte");
            EnContact = true;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (EnContact == true)
            {
                Debug.Log("Perdu !");
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localPosition += transform.forward * speed;
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localPosition += transform.forward * -speed;
            }


            if (chrono > 1)
            {
                chrono--;
                transform.Translate(-Vector3.right * vitesseBaguette);
            }
            else
            {
                chrono = 0;
                Debug.Log("Gagné !");
            }
        }
    }
}