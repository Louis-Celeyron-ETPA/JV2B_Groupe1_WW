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
        private int GoalMove;
        public int Score;
        private Vector3 initialPose;
        private Vector3 GoalPose;
        private float pourcentage = 0f;
        public Text ScoreText;
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
