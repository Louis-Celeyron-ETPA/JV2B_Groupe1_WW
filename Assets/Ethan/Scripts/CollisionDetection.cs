using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class CollisionDetection : MonoBehaviour
    {

        int nbrCollisions = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (nbrCollisions == 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            Debug.Log(nbrCollisions);
        }

        private void OnTriggerEnter(Collider other)
        {
            nbrCollisions ++;
        }

        private void OnTriggerExit(Collider other)
        {
            nbrCollisions --;
        }
    }
}
