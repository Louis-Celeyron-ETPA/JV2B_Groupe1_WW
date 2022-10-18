using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluve
{
    public class InputMini2 : MonoBehaviour
    {

        public float speed = 125;
        public Rigidbody rb;
        void Start()
        {
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            Physics.gravity = new Vector3(0, -300, 0);
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(-Vector3.right * (speed));
            }
            if (Input.GetKey(KeyCode.Q))
            {
                rb.AddForce(Vector3.right * (speed));
            }
        }

    }
}
