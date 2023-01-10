using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class Pancake : MonoBehaviour
    {
        //********* Init des variables *****************
        public Rigidbody rb;
        public CamDeplacement ScoreP;
        public bool didScore = false;
        Vector3 veloY;
        //*********************************************

        void Start()
        {
            //************ Au lancement *************
            rb = GetComponent<Rigidbody>();
            ScoreP = Camera.main.GetComponent<CamDeplacement>();
            veloY = rb.velocity;
            veloY.y = 0f;
            rb.velocity = veloY;
            //*********************************************
        }

        //*************** Pour chaque frame *******************************
        void Update()
        {
            if(ScoreP.Score==6){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (transform.position.y <= -1.9f)
            {
                ScoreP.Score -= 1;
                Destroy(gameObject);
            }
        }
        //******************************************************************
        //***************Fonction appeler quand collision*******************
        private void OnCollisionEnter(Collision collision)
        {
            if(!didScore)
            {
                transform.SetParent(collision.transform);
                transform.rotation = Quaternion.Euler(90,0,0);  //set en child l'objet en conctace avec l'assiette
                rb.isKinematic = true;
                ScoreP.Score+=1;
            }
            didScore = true; 
        }
        //*******************************************************************
    }
}
