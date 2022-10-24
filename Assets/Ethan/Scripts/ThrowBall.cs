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
        float forceForward = 5;
        float forceUp = 6f;
        int ballCapacity = 5;

        // UI
        public TextMeshProUGUI score;

        // Start is called before the first frame update
        void Start()
        {
            score.text = ballCapacity.ToString();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void throwBall()
        {
            if (ballCapacity > 0)
            {
                GameObject ball = Instantiate(ballPrefab, transform.position - new Vector3(0, 1, 0), Quaternion.identity) as GameObject;
                ball.GetComponent<Rigidbody>().velocity = new Vector3(0, forceUp, forceForward);
                ballCapacity -= 1;
                score.text = ballCapacity.ToString();
            }            
        }
    }
}
