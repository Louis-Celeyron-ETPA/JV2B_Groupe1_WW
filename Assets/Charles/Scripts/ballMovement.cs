using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Charles
{
    public class ballMovement : MonoBehaviour
    {
        public Rigidbody rb;
        public Vector3 startPos;
        public Vector3 startScale;
        public Vector3 miniScale = new Vector3(0f, 0f, 0f);
        public float delta;
        public bool shouldShrink = false;
    // Start is called before the first frame update
        void Start()
        {
            startScale = transform.localScale;
            startPos = transform.position;
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (shouldShrink)
            {
                delta += Time.deltaTime;
                transform.localScale = Vector3.Lerp(startScale, miniScale, delta);
            }
            if (delta >= 1)
            {
                shouldShrink = false;
                delta = 0;
                TpBack();
            }
        }

        public void RightMove()
        {
            rb.velocity += new Vector3(0.01f, 0f, 0f);
        }
        public void LeftMove()
        {
            rb.velocity += new Vector3(-0.01f, 0f, 0f);
        }
        public void FrontMove()
        {
            rb.velocity += new Vector3(0f, 0f, 0.01f);
        }
        public void BackMove()
        {
            rb.velocity += new Vector3(0f, 0f, -0.01f);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Spike")
            {
                TpBack();
            }
            if (collision.gameObject.tag == "Finish")
            {
                Debug.Log("gagné");
                delta = 0;
                shouldShrink = true;
            }

        }

        private void TpBack()
        {
            Debug.Log("je suis de retour");

            transform.localScale = startScale;
            transform.position = startPos;
            rb.velocity = new Vector3(0.0f, 0f, 0f);
        }
    }

}

