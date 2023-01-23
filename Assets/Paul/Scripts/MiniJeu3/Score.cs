using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class Score : MonoBehaviour
    {
        public Text colorChose;
        public Detecteur detecteur;
        public bool victory;
        public bool defeat;
        // Start is called before the first frame update
        void Start()
        {
            victory = false;
            defeat = false;
        }

        // Update is called once per frame
        void Update()
        {
            // gestion de l'ui du compteur de boite détecté par la machine
            if (victory == false && defeat == false)
            {
                colorChose.text = detecteur.gagner.ToString() + "/10";
            }
            // tu gagnes quand on detecte 10 boites avant le timer
            if (detecteur.gagner == 10 && defeat == false)
            {
                victory = true;
                colorChose.text = "VICTOIRE";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            
            if (defeat == true && victory == false)
            {
              colorChose.text = "DEFAITE";
            }
        }
    }
}