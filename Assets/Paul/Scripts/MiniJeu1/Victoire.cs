using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class Victoire : MonoBehaviour
    {
        public Text text;
        public float timer;
        public bool victory;
        public bool defeat;
        // Start is called before the first frame update
        void Start()
        {
            timer = 15f;
            victory = false;
            defeat = false;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (victory == false && defeat == false)
            {
                text.text = timer.ToString("#");
            }

            if (timer < 0f && victory == false)
            {
                Debug.Log("D�faite");
                text.text = "DEFAITE";
                defeat = true;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player" && defeat == false)
            {
                Debug.Log("Victoire");
                Debug.Log(text .gameObject);
                text.text = "VICTOIRE";
                victory = true;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}