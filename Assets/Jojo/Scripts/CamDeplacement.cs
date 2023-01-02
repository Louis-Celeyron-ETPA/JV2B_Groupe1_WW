using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Jojo
{
    public class CamDeplacement : MonoBehaviour
    {
        public int GoalMove;
        public int Score;
        Vector3 initialPose;
        Vector3 GoalPose;
        float pourcentage = 0f;
        public Text ScoreText;
        // Start is called before the first frame update
        void Start()
        {
            Score=0;
        }

        // Update is called once per frame
        void Update()
        {
            ScoreText.text=Score.ToString();
            if(Score==GoalMove){
                if (pourcentage == 0)
                {
                    initialPose = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    GoalPose = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
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
    }
}
