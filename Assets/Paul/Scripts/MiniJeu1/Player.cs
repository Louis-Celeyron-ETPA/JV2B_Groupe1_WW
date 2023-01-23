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

        // il y a trois niveaux de difficulté qui définissent la vitesse max de la voiture et sa vitesse d'accélération

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

        // La voiture prend de la vitesse au fur et à mesure jusqu'à atteindre le max qui est défini par la difficulté du jeu
       
        void Update()
        {
            if(vitesse < GetVitesseMax())
            {
                vitesse = vitesse + GetAcceleration();
            }
            rb.velocity = rb.velocity.normalized;
            rb.AddForce(Vector3.forward * vitesse);
            
           
        }

        // Tourne à gauche et droite en s'adaptant à la vitesse actuelle

        public void ToucheDroite()
        {
          
                rb.AddForce(Vector3.right * (vitesse / 4));
            
        }
        public void ToucheGauche()
        {

            rb.AddForce(Vector3.left * (vitesse / 4));

        }

        // Si tu te prends une voiture, ta vitesse redescend presque à zéro

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "MyGameObjectTag")
            {
                vitesse = 50;
                
            }
        }
    }

}