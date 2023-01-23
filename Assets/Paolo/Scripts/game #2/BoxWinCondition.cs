using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{ 
    public class BoxWinCondition : MonoBehaviour
    {
        public bool Victory;
        public bool Defeat;
        public float Timer;
        public GameObject Rainbow;
        public GameObject Gold;
        public GameObject Star;
        // Start is called before the first frame update
        void Start()
        {
            Timer = 15f;
            Victory = false;
            Defeat = true;
            Gold.SetActive(true);
            Rainbow.SetActive(false);
            Star.SetActive(false);
        }

        void Update()
        {
            Timer -= Time.deltaTime;

            if (Timer < 0 && Victory==true)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            if (Timer < 0 && Defeat == true)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }

        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("gagner");
            Victory = true;
            Defeat = false;
            Rainbow.SetActive(true);
            Star.SetActive(true);
            Gold.SetActive(false);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("perdu");
            Defeat = true;
            Victory = false;
            Gold.SetActive(true);
            Rainbow.SetActive(false);
            Star.SetActive(false);
        }

    }
}
