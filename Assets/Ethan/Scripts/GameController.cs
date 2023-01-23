using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class GameController : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        [SerializeField]
        private TextMeshProUGUI objectifText;

        public int score = 0;
        public int objective = 5;

        // Start is called before the first frame update
        void Start()
        {
            // Augmentation de l'objectif en fonction de la difficulté
            //objective = 5 * (ManagerManager.DifficultyManager.GetDifficulty() + 1);
            objectifText.text = "Objectif : " + objective.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if (score == objective)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}