using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluve
{
    public class SpawnerMoving : MonoBehaviour
    {
        public Rigidbody rb;
        public bool ChangeDirection = false;
        public int speed;

        public int coutnerChangeDirection;
        public float coutnerChangeDirectionMax = 200;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            if (ChangeDirection == false)
            {
                rb.AddForce(-Vector3.left * (speed));
            }
            if (ChangeDirection == true)
            {
                rb.AddForce(-Vector3.right * (speed));
            }

            coutnerChangeDirection++;

            if (coutnerChangeDirection >= coutnerChangeDirectionMax)
            {
                if (ChangeDirection == false)
                {
                    speed *= (-1);
                }
                if (ChangeDirection == true)
                {
                    speed *= (-1);
                }

                coutnerChangeDirectionMax = Random.Range(50, 300);
                coutnerChangeDirection = 0;
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
                 if (ChangeDirection == true)
                {
                    ChangeDirection = false;
                }
            }

        }
    }
}
