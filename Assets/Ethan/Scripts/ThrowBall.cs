using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class ThrowBall : MonoBehaviour
    {
        // Normal
        public GameObject ballPrefab;
        float forceForward = 4f;
        float forceUp = 7f;
        float puissance = 5f;
        float timeUp = 0f;
        float timeDown = 0f;
        float timeAutoDecreasePower = 0.4f;
        float maxCoutdown = 0.1f;
        bool stopCountdown = false;

        // UI
        public TextMeshProUGUI puissanceScore;

        // Start is called before the first frame update
        void Start()
        {
            puissanceScore.text = puissance.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if (timeUp > 0)
            {
                timeUp -= Time.deltaTime;
            }
            if (timeDown > 0)
            {
                timeDown -= Time.deltaTime;
            }
            if (timeAutoDecreasePower > 0 && stopCountdown == false)
            {
                timeAutoDecreasePower -= Time.deltaTime;
            }
            else
            {
                timeAutoDecreasePower = maxCoutdown*4;
                if (puissance>0 && stopCountdown == false)
                {
                    puissance -= 1;
                    puissanceScore.text = puissance.ToString();
                }
            }
        }

        public void Throw()
        {
            GameObject ball = Instantiate(ballPrefab, transform.position - new Vector3(0, 1, 0), Quaternion.identity) as GameObject;
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, forceUp * (0.95f + (puissance / 60)), forceForward * (0.95f + (puissance / 60)));       
        }

        public void IncreasePower()
        {
            stopCountdown = true;
            if (puissance<10 && timeUp <= 0)
            {
                puissance += 1;
                puissanceScore.text = puissance.ToString();
                timeUp = maxCoutdown;                
            }            
        }

        public void DecreasePower()
        {
            stopCountdown = true;
            if (puissance > 0 && timeDown <= 0)
            {
                puissance -= 1;
                puissanceScore.text = puissance.ToString();
                timeDown = maxCoutdown;
            }
        }

        public void DoingNothing()
        {
            stopCountdown = false;
        }
    }
}
