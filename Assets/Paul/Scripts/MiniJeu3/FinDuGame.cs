using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class FinDuGame : MonoBehaviour
    {
        public Text text;
        public float timer = 0.0f;
        public Score score;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // UI du timer
            timer += Time.deltaTime;
            Debug.Log(timer);
            text.text = timer.ToString("#");

            // Tu perds quand le timer est fini
            if (timer >= 15f)
            {
                score.defeat = true;
                
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}