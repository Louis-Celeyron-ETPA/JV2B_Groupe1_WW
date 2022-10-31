using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{

    public class Ennemi : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed;
        public float aleatoire;
        // Start is called before the first frame update
        void Start()
        {
            aleatoire = Random.Range(0f, 1f);

            if (aleatoire <= 0.5)
            {
                speed = -0.05f;
            }
            if (aleatoire > 0.5)
            {
                speed = 0.05f;
            }
            Debug.Log(aleatoire);
        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            transform.position += transform.right * speed;
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Mur")
            {
                speed = speed * -1;
            }
        }
    }
}