using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class DefendreScript : MonoBehaviour
    {

        //************************************ INITIATION DES VARIABLES ************************************
        public int chrono = 800;
        public float speed = 0.05f;
        public float vitesseBaguette = 0.0003f;
        public float sensitivity = 1.5f;
        public KeyCode avance;
        public KeyCode recule;
        public int finDuJeu = 0;


        //************************************ VERIFICATION DE LA SORTIE DE LA CAPSULE DE LA BOX INVISIBLE ************************************
        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Salut mon pote !");
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }
        
        
        // Start is called before the first frame update
        void Start()
        {

        }

        //************************************ MISE EN PLACE DU CHRONOMETRE ************************************
        // Update is called once per frame
        void Update()
        {
            if (chrono > 1)
            {
                chrono--;
            }
            else if (chrono < 1){
                finDuJeu = 1;

                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);

            }

        }

        //************************************ DEPLACEMENT DU PARAPLUIE ************************************
        public void FonctionParapluie(int ChoixParapluie)
        {
            if (chrono > 1)
            {
                if (ChoixParapluie == 1)
                {
                    transform.localPosition += transform.up * speed;
                }

                else if (ChoixParapluie == 2)
                {
                    transform.localPosition += transform.up * -speed;
                }
            }
        }
    }
}
