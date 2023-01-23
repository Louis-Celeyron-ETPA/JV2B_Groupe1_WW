using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class MoveTrain : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public Rigidbody rb;
        public int speed;

        public float[] vitesseTrain;

        ///////////////////////////////////////////////////

        public float GetVitesseMax()
        {
            return vitesseTrain[ManagerManager.DifficultyManager.GetDifficulty()];
        }

        void Update()
        {
            // d�placement du train vers la gauche selon la difficult�

            rb.velocity = Vector3.right * GetVitesseMax();
        }

    }
}
