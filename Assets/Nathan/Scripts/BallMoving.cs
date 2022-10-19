using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Pediluve
{
    public class BallMoving : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed;
        private bool stopRotateAndMove = false;

        void Start()
        {
        }

        void Update()
        {
            Physics.gravity = new Vector3(0, -100, 0);

            rb.velocity = rb.velocity.normalized;


            if (stopRotateAndMove == false)
            {
                transform.Rotate(Vector3.left * 2f);
                rb.velocity = rb.velocity.normalized;
                rb.AddForce(-Vector3.forward * (speed));
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "otherBall")
            {
                transform.Rotate(0, 0, 0);
                rb.AddForce(Vector3.forward * 0);
                stopRotateAndMove = true;
            }
            

        }
    }
}
