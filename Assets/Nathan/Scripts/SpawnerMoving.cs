using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class SpawnerMoving : MonoBehaviour
    {
        public Rigidbody rb;
        public bool ChangeDirection = true;
        public int speed;

        public float coutnerChangeDirection;
        public float coutnerChangeDirectionMax;

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

            coutnerChangeDirection += Time.deltaTime;
            Debug.Log(coutnerChangeDirectionMax);

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

                coutnerChangeDirectionMax = Random.Range(2, 6);
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
