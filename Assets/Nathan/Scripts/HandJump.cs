using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class HandJump : MonoBehaviour
    {
        public float jumpAmount = 10;
        public Rigidbody rb;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Wall")
            {
                rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            }


        }
    }
}
