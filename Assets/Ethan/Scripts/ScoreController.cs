using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class ScoreController : MonoBehaviour
    {
        // UI
        public TextMeshProUGUI scoreText;

        // Drones
        public AiMove drone1;
        public AiMove drone2;

        // Normal
        public int score = 0;

        // Start is called before the first frame update
        void Start()
        {
            // Augmentation du nombre de drône et de la vitesse en fonction de la difficulté
            //if(ManagerManager.DifficultyManager.GetDifficulty() == 0)
            //{
                //Destroy(drone2);
            //}
            //else if (ManagerManager.DifficultyManager.GetDifficulty() == 2)
            //{
                //drone1.speed = 0.01f;
                //drone2.speed = 0.01f;
            //}
        }

        // Update is called once per frame
        void Update()
        {
            if (score == 20)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}