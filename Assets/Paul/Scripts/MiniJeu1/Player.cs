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
        public int[] VitesseMax;
        public int[] Acceleration;
        public int GetVitesseMax()
        {
            return VitesseMax[ManagerManager.DifficultyManager.GetDifficulty()];
        }
        public int GetAcceleration()
        {
            return Acceleration[ManagerManager.DifficultyManager.GetDifficulty()];
        }

        // Start is called before the first frame update
        void Start()
        {
            posX = transform.position.x;
            posY = transform.position.y;
            posZ = transform.position.z;
            vitesse = 200;
            ManagerManager.DifficultyManager.GetDifficulty();
        }

        // Update is called once per frame
        void Update()
        {
            if(vitesse < GetVitesseMax())
            {
                vitesse = vitesse + GetAcceleration();
            }
            rb.velocity = rb.velocity.normalized;
            rb.AddForce(Vector3.forward * vitesse);
            
           
        }
        public void ToucheDroite()
        {
          
                rb.AddForce(Vector3.right * (vitesse / 4));
            
        }
        public void ToucheGauche()
        {

            rb.AddForce(Vector3.left * (vitesse / 4));

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