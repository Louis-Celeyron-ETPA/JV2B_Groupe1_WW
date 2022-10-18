using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class MovementBase : MonoBehaviour
    {
        public KeyCode droite;
        public KeyCode gauche;

        float speed = 0.13f;


        void Start()
        {
            {

            }
        }

        void Update()
        {
            if (Input.GetKey(droite))
            {
                transform.localPosition += transform.right * speed;
            }
            else if (Input.GetKey(gauche))
            {
                transform.localPosition += transform.right * -speed;
            }

            if (transform.position.x > 4.24)
            {
                transform.position = new Vector3(-3.9f,0.52f,-6.8f);
                Debug.Log("oui");
            }
            if (transform.position.x < -4.24)
            {
                transform.position = new Vector3(3.9f, 0.52f, -6.8f);
                Debug.Log("oui");
            }


        }
    }
}