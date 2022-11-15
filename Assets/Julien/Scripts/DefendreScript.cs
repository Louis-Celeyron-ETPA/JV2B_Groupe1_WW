using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cunegonde
{
    public class DefendreScript : MonoBehaviour
    {
        public int chrono = 7600;
        public float speed = 0.05f;
        public float vitesseBaguette = 0.0003f;
        public float sensitivity = 1.5f;
        public KeyCode avance;
        public KeyCode recule;


        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Salut mon pote !");
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            


        }

        public void FonctionParapluie(int ChoixParapluie)
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
