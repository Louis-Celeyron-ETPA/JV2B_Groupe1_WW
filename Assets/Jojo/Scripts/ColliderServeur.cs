using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class ColliderServeur : MonoBehaviour
    {
        public int ScoreCoffee;
        public GameObject Tasse;
        // Start is called before the first frame update
        void Start()
        {
            ScoreCoffee = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if(ScoreCoffee>=3){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }

        private void OnTriggerEnter(Collider other){
            if(other.gameObject.tag == "TasseTag"){
                other.gameObject.SetActive(false);
                ScoreCoffee+=1;
            }
        }
    }
}