using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class DetectBall : MonoBehaviour
    {
        [SerializeField]
        private GameController gC;
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
            gC.score += 1;
            gC.scoreText.text = gC.score.ToString();
            Destroy(collision.gameObject);
        }
    }
}