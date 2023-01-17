using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Jojo
{
    public class CamDeplacement : MonoBehaviour
    {
        //********* Init des variables *****************
        public int GoalMove;
        public int Score;
        private Vector3 initialPose;
        private Vector3 GoalPose;
        private float pourcentage = 0f;
        public Text ScoreText;
        public float TimerPancake=15;
        // *********************************************
        void Start()
        {
        //************ Au lancement **************************
            Score=0;
        // ***************************************************
        }

        //*************** Pour chaque frame *******************************
        void Update()
        {
            TimerPancake-=Time.deltaTime;

            if(TimerPancake<=0){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  // verifie si le temps est a zero si oui alors defaite
            }

            ScoreText.text=Score.ToString();
            if(Score==GoalMove){
                if (pourcentage == 0)
                {
                    initialPose = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    GoalPose = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);       // mouvement de la camera quand score atteint X
                }
                transform.position=Vector3.Lerp(initialPose, GoalPose, pourcentage);        
                pourcentage += 0.005f;
            }
            if (pourcentage >= 0.93)
            {
                GoalMove += 11;
                pourcentage = 0;
            }
        }
        // ************************************************************
    }
}
