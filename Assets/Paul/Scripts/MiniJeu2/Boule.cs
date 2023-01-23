using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Paul
{
    public class Boule : MonoBehaviour
    {
        public Rigidbody rb;
        public Canon canon;
        public ScoreBall score;

        // Le boulet de canon est calibré pour qu'il part dans la même direction que le canon
        void Start()
        {

            transform.rotation = canon.transform.rotation;

        }

        // Apparition du boulet. Il va tout droit.
        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            transform.position += transform.up;
        }
        // Si il touche les bateaux ennemis, le boulet disparait avec le bateau
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Ennemy")
            {
                
                Destroy(collision.gameObject);
                score.scoreTotal += 1;
                Destroy(gameObject);
                
            }
        }
    }
}
