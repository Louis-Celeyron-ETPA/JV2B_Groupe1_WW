using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
public class Deplacements : MonoBehaviour
{
        public int chrono = 1000;
        public float speed = 0.002f;
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
            }
            else
            {
                chrono = 0;
                Debug.Log("Gagné !");
            }
        }
}
}
