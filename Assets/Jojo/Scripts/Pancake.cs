using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class Pancake : MonoBehaviour
    {
        public Rigidbody rb;
        public CamDeplacement ScoreP;
        public bool didScore = false;
        Vector3 veloY;
        // Start is called before the first frame update

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            ScoreP = Camera.main.GetComponent<CamDeplacement>();
            veloY = rb.velocity;
            veloY.y = 0f;
            rb.velocity = veloY;
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y <= -1.9f)
            {
                ScoreP.Score -= 1;
                Destroy(gameObject);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(!didScore)
            {
                transform.SetParent(collision.transform);
                transform.rotation = Quaternion.Euler(90,0,0);
                rb.isKinematic = true;
                ScoreP.Score+=1;
            }
            didScore = true; 
        }
 
    }
}
