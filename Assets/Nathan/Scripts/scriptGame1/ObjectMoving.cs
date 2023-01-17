using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pediluves
{
    public class ObjectMoving : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public Rigidbody rb;
        public bool ChangeDirection = false;
        public int speed;

        public InputMini1 player;

        public float[] speedMax;

        public float GetSpeedMax()
        {
            return speedMax[0];
            //return speedMax[ManagerManager.DifficultyManager.GetDifficulty()];
        }

        ///////////////////////////////////////////////////

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            if (ChangeDirection == false)
            {
                rb.AddForce(Vector3.forward * (GetSpeedMax()));
            }
            if (ChangeDirection == true)
            {
                rb.AddForce(-Vector3.forward * (GetSpeedMax()));
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

