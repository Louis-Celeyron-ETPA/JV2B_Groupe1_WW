using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class AiMove : MonoBehaviour
    {
        [SerializeField]
        private ScoreController sC;
        public List<Point> allPoints;
        [SerializeField]
        private Cheat cheat;

        public int currentPoint;
        Vector3 oldPos;
        Vector3 targetPoint;

        float pourcentage = 0f;
        public float speed = 0.005f;

        // Start is called before the first frame update
        void Start()
        {
            newTarget();
        }

        // Update is called once per frame
        void Update()
        {
            if (pourcentage < 1)
            {
                Move();
                pourcentage += speed;
            }
            else
            {
                pourcentage = 0;
                newTarget();
            }
        }

        void Move()
        {
            transform.position = Vector3.Lerp(oldPos, targetPoint, pourcentage);
        }

        void newTarget()
        {
            oldPos = transform.position;
            var target = allPoints[currentPoint].nearPoints[Random.Range(0, allPoints[currentPoint].nearPoints.Count)];
            targetPoint = target.theTransform.position;
            currentPoint = target.pointIndex;
        }

        private void OnTriggerStay(Collider other)
        {
            if (cheat.isCheating)
            {
                sC.score = 0;
                sC.scoreText.text = "Note actuelle : " + sC.score.ToString() + "/20";
            }            
        }
    }
}