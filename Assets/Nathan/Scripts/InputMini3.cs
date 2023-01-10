using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pediluves
{
    public class InputMini3 : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public int counter = 0;
        public Text counterText;
        public bool end = false;

        public bool isPress = false;

        public RandomSpawner randomSpawner;

        ///////////////////////////////////////////////////

        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            // actualise l'affichage en fonction de notre score

            counterText.text = counter.ToString();
        }

        public void leftMovement()
        {
            // diminue la valeur
            
            if (!isPress)
            {
                if (counter > 0)
                {
                    isPress = true;
                    counter --;
                }
            }
        }
        public void rightMovement()
        {
            // augmente la valeur

            if (!isPress)
            {
                isPress = true;
                counter++;
            }
        }

        public void onUp()
        {
            isPress = false;
        }

        public void actionMovement()
        {
            // valider le score

            if (counter == randomSpawner.counterEnd)
            {
                end = true;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else
            {
                end = false;
            }
        }
    }
}
