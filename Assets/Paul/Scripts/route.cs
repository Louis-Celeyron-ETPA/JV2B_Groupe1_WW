using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{
    public class route : MonoBehaviour
    {
        public Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            rb.AddForce(Vector3.forward * 2f);
        }
    }
}