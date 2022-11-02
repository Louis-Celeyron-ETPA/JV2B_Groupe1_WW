using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class PlayerMovement : MonoBehaviour
    {
        Vector3 pos1 = new Vector3(-2.65f, 3.5f, -5f);
        Vector3 pos2 = new Vector3(2.65f, 3.5f, -5f);
        float pourcentage = 0f;
        float speed = 0.003f;
        bool retour = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Déplacement
            transform.position = Vector3.Lerp(pos1, pos2, pourcentage);
            // Vers la droite ou vers la gauche
            if (retour)
            {
                pourcentage -= speed;
            }
            else
            {
                pourcentage += speed;
            }
            // Dans quel direction je dois aller
            if (pourcentage >= 1)
            {
                retour = true;
            }
            else if (pourcentage <= 0)
            {
                retour = false;
            }
        }
    }

}