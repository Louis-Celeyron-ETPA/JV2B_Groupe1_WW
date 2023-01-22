using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class GameController : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI objectifText;

        public int score = 0;
        public int objectif = 5;

        // Start is called before the first frame update
        void Start()
        {
            objectifText.text = "Objectif : " + objectif.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = score.ToString();
            if (score == objectif)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}