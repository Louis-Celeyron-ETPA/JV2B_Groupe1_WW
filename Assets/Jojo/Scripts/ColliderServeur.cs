using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class ColliderServeur : MonoBehaviour
    {
        //********* Init des variables *****************
        private int ScoreCoffee;
        private GameObject Tasse;
        private float TimerServ=15;
        // ***************************************************
        void Start()
        {
            //************ Au lancement **************************
            ScoreCoffee = 0;
            // ***************************************************
        }

        // Update is called once per frame
        void Update()
        {
            //*************** Pour chaque frame *******************************
            TimerServ -= Time.deltaTime;
            if(ScoreCoffee>=3){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);     // verifie si le joueur a servie trois tasse si oui alors victoire du mini jeu
            }

            if(TimerServ<=0){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  // verifie si le temps est a zero si oui alors defaite
            }
            // ***************************************************
        }
        //***********Fonction qui verifie quand la tasse entre en collision avec le client
        private void OnTriggerEnter(Collider other){
            if(other.gameObject.tag == "TasseTag"){
                other.gameObject.SetActive(false);   // si il entre en collision alors desactive la tasse et augmenter le score der 1
                ScoreCoffee+=1;
            }
        }
        //*****************************
    }
}