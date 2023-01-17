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
        public float speed;

        public float coutnerChangeDirection;
        public float coutnerChangeDirectionMax;

        public float[] vitesseSpawner;

        public float GetVitesseMax()
        {
            return vitesseSpawner[2];
            //return vitesseSpawner[ManagerManager.DifficultyManager.GetDifficulty()];
        }

        ///////////////////////////////////////////////////

        public void Start()
        {
            speed = GetVitesseMax();
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            // déplacement vers la droite 
            if (ChangeDirection == false)
            {
                rb.AddForce(-Vector3.left * (GetVitesseMax()));
            }

            // déplacement vers la gauche 
            if (ChangeDirection == true)
            {
                rb.AddForce(-Vector3.right * (GetVitesseMax()));
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
