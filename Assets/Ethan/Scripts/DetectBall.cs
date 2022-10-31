using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class DetectBall : MonoBehaviour
    {
        public GameController gc;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            gc.score += 1;
            Destroy(collision.gameObject);
        }
    }
}