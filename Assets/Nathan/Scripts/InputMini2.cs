using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace Pediluves
{
    public class InputMini2 : MonoBehaviour
    {

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
        }
        public void leftMovement()
        {
            rb.AddForce(Vector3.right * (speed));
        }
        public void rightMovement()
        {
            rb.AddForce(-Vector3.right * (speed));
        }
        public void actionMovement()
        {
            if (stopActive == false && isClose == true)
            {
                animator.SetTrigger("Ouvrir");
                stopActive = true;
                speed /= 3;
            }

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
            if (collision.gameObject.tag == "otherBall" && stopActive == true)
            {
                score++;
                Destroy(collision.gameObject);
            }

        }
    }
}
