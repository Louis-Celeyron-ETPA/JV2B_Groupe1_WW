using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pediluve
{
    public class ObjectMoving : MonoBehaviour
    {
        public Rigidbody rb;
        public bool ChangeDirection = false;
        public int speed;

        public InputManager player;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            if (ChangeDirection == false)
            {
                rb.AddForce(Vector3.forward * (speed));
            }
            if (ChangeDirection == true)
            {
                rb.AddForce(-Vector3.forward * (speed));
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Wall")
            {
                if (ChangeDirection == false)
                {
                    ChangeDirection = true;
                }
                else
                {
                    ChangeDirection = false;
                }
            }

            if (collision.gameObject.tag == "Player")
            {
                player.respawn = true;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                player.respawn = false;
            }
        }
    }
}

