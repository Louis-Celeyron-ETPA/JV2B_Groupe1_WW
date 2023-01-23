using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{

    public class Cheat : MonoBehaviour
    {
        public ScoreController sC;

        float timer;
        float maxTimer = 0.1f;

        public bool isCheating = false;

        // Start is called before the first frame update
        void Start()
        {
            timer = maxTimer;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "CanCheat")
            {
                isCheating = true;

                if (timer >= 0)
                {
                    timer -= Time.deltaTime;
                }
                else
                {
                    timer = maxTimer;
                    if (sC.score<20)
                    {
                        sC.score++;
                    }
                    sC.scoreText.text = "Note actuelle : " + sC.score.ToString() + "/20";
                }
            }            
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "CanCheat")
            {
                isCheating = false;
                timer = maxTimer;
            }
        }
    }
}
