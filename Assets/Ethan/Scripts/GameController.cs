using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class GameController : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        public int score = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = score.ToString();
        }
    }
}