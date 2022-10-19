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
        public Rigidbody rb;

        public int score;
        public Text scoreText;

        void Start()
        {
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;

            Physics.gravity = new Vector3(0, -300, 0);
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(-Vector3.right * (speed));
            }
            if (Input.GetKey(KeyCode.Q))
            {
                rb.AddForce(Vector3.right * (speed));
            }

            scoreText.text = score.ToString();

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "otherBall")
            {
                score++;
            }

        }
    }
}
