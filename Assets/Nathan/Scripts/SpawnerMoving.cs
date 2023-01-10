using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class SpawnerMoving : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////
        
        public Rigidbody rb;
        public bool ChangeDirection = true;
        public int speed;

        public float coutnerChangeDirection;
        public float coutnerChangeDirectionMax;

        ///////////////////////////////////////////////////

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            // déplacement vers la droite 
            if (ChangeDirection == false)
            {
                rb.AddForce(-Vector3.left * (speed));
            }

            // déplacement vers la gauche 
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

                // changement de direction après un temps random
                coutnerChangeDirectionMax = Random.Range(2, 6);
                coutnerChangeDirection = 0;
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            // lorsque l'object touche 1 des murs, il part dans le sens opposé

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
