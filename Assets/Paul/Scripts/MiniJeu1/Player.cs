using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{
    public class Player : MonoBehaviour
    {
        public Rigidbody rb;
        public float posX;
        public float posY;
        public float posZ;
        public float vitesse;

        // Start is called before the first frame update
        void Start()
        {
            posX = transform.position.x;
            posY = transform.position.y;
            posZ = transform.position.z;
            vitesse = 200;
        }

        // Update is called once per frame
        void Update()
        {
            if(vitesse < 1300)
            {
                vitesse = vitesse + 5;
            }
            rb.velocity = rb.velocity.normalized;
            rb.AddForce(Vector3.forward * vitesse);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * (vitesse/4));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * (vitesse/4));
            }
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "MyGameObjectTag")
            {
                vitesse = 50;
                
            }
        }
    }

}