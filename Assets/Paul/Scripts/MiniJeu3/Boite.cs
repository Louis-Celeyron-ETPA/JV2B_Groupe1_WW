using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Paul
{
    public class Boite : MonoBehaviour
    {
        public ColorSwitch colorSwitch;
        public Rigidbody rb;
        public bool verifier;
        public bool checkCouleur;
        public Material Material1;
        public Material Material2;
        public GameObject Object;
        public float random;

        private bool isOnTruc;
        // Start is called before the first frame update
        void Start()
        {
            // Les boites sont aléatoirement rouges ou bleues
            
            random = Random.Range(0f, 1f);

            if (random < 0.5f)
            {
                Object.GetComponent<MeshRenderer>().material = Material1;
                checkCouleur = true;
            }
            if (random > 0.5f)
            {
                Object.GetComponent<MeshRenderer>().material = Material2;
                checkCouleur = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            // Elles avancent.
            rb.velocity = rb.velocity.normalized;
            transform.position += transform.right * 0.15f;
        }

        public void OnCollisionEnter(Collision collision)

            // les boites sont censées disparaitre en touchant le mur du fond mais ça marche pas !!!
        {
            if (collision.gameObject.tag == "TagLa")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}