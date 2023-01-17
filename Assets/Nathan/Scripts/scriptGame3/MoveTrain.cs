using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class MoveTrain : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public Rigidbody rb;
        public int speed;

        ///////////////////////////////////////////////////

        void Update()
        {
            // déplacement du train

            rb.velocity = Vector3.right * speed;
        }

    }
}
