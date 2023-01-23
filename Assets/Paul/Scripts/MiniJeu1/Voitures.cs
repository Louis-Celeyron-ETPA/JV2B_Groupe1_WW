using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{
    public class Voitures : MonoBehaviour
    {
        public Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // La voiture que tu percutes explose dans les airs trop rigolo ahahah

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                rb.AddForce(Vector3.up * 1000);
                rb.AddForce(Vector3.left * 500);

            }
        }
    }
}