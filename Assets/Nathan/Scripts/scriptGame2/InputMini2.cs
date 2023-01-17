using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace Pediluves
{
    public class InputMini2 : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public float speed;
        private float speedMax;
        public Rigidbody rb;

        public int score;
        public Text scoreText;

        public bool stopActive = false;

        //public int counterStop;
        //private int counterStopMax = 10;

        public Animator animator;

        public bool isClose = true;

        public int scoreMax;

        public float timer = 15;

        ///////////////////////////////////////////////////

        void Start()
        {
            speedMax = speed;
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            Physics.gravity = new Vector3(0, -300, 0);

            if (stopActive == false)
            {
                speed = speedMax;
            }

            scoreText.text = score.ToString();

            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }

            if (score == scoreMax)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

        }
        public void leftMovement()
        {
            // déplace vers la gauche

            rb.AddForce(Vector3.right * (speed));
        }
        public void rightMovement()
        {
            // déplace vers la droite

            rb.AddForce(-Vector3.right * (speed));
        }
        public void actionMovement()
        {
            // permet d'ouvrir les gants et de stop la balle

            if (stopActive == false && isClose == true)
            {
                animator.SetTrigger("Ouvrir");
                stopActive = true;
                speed /= 3;
            }

            // permet de fermer les gants et de stop la balle

            if (stopActive == true && isClose == false)
            {
                stopActive = false;
                animator.SetTrigger("Fermer");
            }
        }

        public void OpenEnd()
        {
            isClose = false;
        }
        public void CloseEnd()
        {
            isClose = true;
        }

        private void OnCollisionEnter(Collision collision)
        {
            // lorsque une balle rentre en collision, elle se détruit et augmente le score global

            if (collision.gameObject.tag == "otherBall" && stopActive == true)
            {
                score++;
                Destroy(collision.gameObject);
            }

        }
    }
}
