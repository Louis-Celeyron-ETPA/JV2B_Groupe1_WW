using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class moveTrain : MonoBehaviour
    {
        public Rigidbody rb;
        public int speed;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = Vector3.right * speed;
        }

    }
}
