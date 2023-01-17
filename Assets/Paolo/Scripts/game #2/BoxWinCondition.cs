using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{ 
    public class BoxWinCondition : MonoBehaviour
    {
        public GameObject Rainbow;
        public GameObject Gold;
        public GameObject Star;
        // Start is called before the first frame update
        void Start()
        {
            Gold.SetActive(true);
            Rainbow.SetActive(false);
            Star.SetActive(false);
        }

        private void OnTriggerStay(Collider other)
        {
            Rainbow.SetActive(true);
            Star.SetActive(true);
            Gold.SetActive(false);
        }

        private void OnTriggerExit(Collider other)
        {
            Gold.SetActive(true);
            Rainbow.SetActive(false);
            Star.SetActive(false);
        }

    }
}
