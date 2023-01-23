using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BananaLover
{
    public class CollisionDetection : MonoBehaviour
    {
        // UI
        [SerializeField]
        private TextMeshProUGUI nbrGobeletRestants;

        // Normal
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
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag != "NeComptePas")
            {
                nbrCollisions++;
            }
            nbrGobeletRestants.text = "Il reste " + nbrCollisions.ToString() + " gobelets";
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag != "NeComptePas")
            {
                nbrCollisions--;
            }
            nbrGobeletRestants.text = "Il reste " + nbrCollisions.ToString() + " gobelets";
        }
    }
}
