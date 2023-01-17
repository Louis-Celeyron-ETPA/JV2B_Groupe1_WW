using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class InputMini1 : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public float speed2 = 0.50f ;   
        public float speed;

        public Rigidbody rb;

        public StopMove stop;

        public bool moveOrDie = false;

        public float startX;
        public float startY;
        public float startZ;

        public bool respawn = false;

        public float timer = 15;

       

        ///////////////////////////////////////////////////

        void Start()
        {
            // save la position de l'object au début

            startX = transform.position.x;
            startY = transform.position.y;
            startZ = transform.position.z;
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            if (stop.dontMove == true)
            {
                moveOrDie = true;
            }
            else
            {
                moveOrDie = false;
            }

            if (respawn == true)
            {
                transform.position = new Vector3(startX, startY, startZ);
            }

            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }

        public void leftMovement()
        {
            // déplacement vers la gauche

            rb.AddForce(-Vector3.right * (speed));

            // si le joueur bouge pendant que le boutton stop est allumé, il respawn au début
            if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void rightMovement()
        {
            // déplacement vers la droite

            rb.AddForce(Vector3.right * (speed));

            // si le joueur bouge pendant que le boutton stop est allumé, il respawn au début
            if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void upMovement()
        {
            // déplacement vers le haut

            rb.AddForce(Vector3.forward * (speed));

            // si le joueur bouge pendant que le boutton stop est allumé, il respawn au début
            if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void downMovement()
        {
            // déplacement vers le bas

            rb.AddForce(-Vector3.forward * (speed));

            // si le joueur bouge pendant que le boutton stop est allumé, il respawn au début
            if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }

        private void OnCollisionEnter(Collision collision)
        {
            // fin du jeu lorsque le joueur touche le lit

            if (collision.gameObject.tag == "Finish")
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }

    }
}
