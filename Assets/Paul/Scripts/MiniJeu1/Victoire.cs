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

        // GEstion de l'UI avec le timer et l'affichage victoire ou défaite

        void Update()
        {
            timer -= Time.deltaTime;

            if (victory == false && defeat == false)
            {
                text.text = timer.ToString("#");
            }

            // On perd à la fin du timer

            if (timer < 0f && victory == false)
            { 
                text.text = "DEFAITE";
                defeat = true;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }

        // On gagne lorsqu'on touche la ligne d'arrivée avant la fin du timer

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player" && defeat == false)
            {
                text.text = "VICTOIRE";
                victory = true;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}