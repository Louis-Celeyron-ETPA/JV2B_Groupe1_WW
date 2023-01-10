using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class ScoreBall : MonoBehaviour
    {
        public int scoreTotal;
        public float timer;
        public Text text;
        private bool victory;
        private bool defeat;
        // Start is called before the first frame update
        void Start()
        {
            scoreTotal = 0;
            timer = 15f;
            victory = false;
            defeat = false;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (victory == false && defeat == false)
            {
                text.text = timer.ToString("#");
            }

            if (scoreTotal == 4 && defeat == false)
            {
                victory = true;
                text.text = "VICTOIRE";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            if (timer <= 0 && victory == false)
            {
                defeat = true;
                text.text = "DEFAITE";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}