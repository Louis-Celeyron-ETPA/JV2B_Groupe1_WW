using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
public class Deplacements : MonoBehaviour
{

        //************************************ INITIATION DES VARIABLES ************************************
        public int chrono = 1050;
        public float speed = 0.0005f;
        public float vitesseBaguette = 0.002f;
        public float sensitivity = 1.5f;
        public KeyCode avance;
        public KeyCode recule;
        public int finDuJeu = 0;
        
        // Start is called before the first frame update
        void Start()
        {

        }


        //************************************ MISE EN PLACE DU CHRONOMETRE ************************************
        // Update is called once per frame
        void Update()
        {
            Debug.Log(chrono);

            if (chrono > 1) 
            {
                chrono--;
                transform.Translate(-Vector3.up * vitesseBaguette);
            }
            else
            {
                chrono = 0;
                Debug.Log("Gagn� !");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }

        //************************************ DEPLACEMENT DE LA BAGUETTE ************************************
        public void FonctionBaguette(int choixBaguette)
        {
            if (choixBaguette == 1)
            {
                transform.localPosition += transform.forward * speed;
            }

            else if (choixBaguette == 2)
            {
                transform.localPosition += transform.forward * -speed;
            }

        }
    }
}
