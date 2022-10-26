using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace Pediluve
{
    public class InputMini2 : MonoBehaviour
    {

        public float speed;
        private float speedMax;
        public Rigidbody rb;

        public int score;
        public Text scoreText;

        public bool stopActive = false;

        public int counterStop;
        private int counterStopMax = 10;

        public Animator animator;


        void Start()
        {
            speedMax = speed;
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            Physics.gravity = new Vector3(0, -300, 0);


            actionMovement();

            if (stopActive == true)
            {
            }
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
            if (stopActive == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetTrigger("Ouvrir");
                    stopActive = true;
                    speed /= 3;
                }
            }

            if (stopActive == true)
            {
                counterStop++;
                if (counterStop >= counterStopMax)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        stopActive = false;
                        counterStop = 0;
                        animator.SetTrigger("Fermer");
                        speed /= 3;
                    }
                }
            }
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
