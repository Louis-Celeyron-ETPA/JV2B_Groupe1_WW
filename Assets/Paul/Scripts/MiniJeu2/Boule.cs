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

        // Start is called before the first frame update
        void Start()
        {

            Debug.Log(canon.rotationZ);
            transform.rotation = canon.transform.rotation;
            Debug.Log(transform.rotation.z);

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            transform.position += transform.up;
        }

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
