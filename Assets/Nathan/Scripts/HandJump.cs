using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class HandJump : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public float jumpAmount = 10;
        public Rigidbody rb;

        ///////////////////////////////////////////////////

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Wall")
            {
                rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            }


        }
    }
}
