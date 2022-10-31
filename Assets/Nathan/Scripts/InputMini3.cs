using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pediluves
{
    public class InputMini3 : MonoBehaviour
    {
        public int counter = 0;
        public Text counterText;
        public bool end = false;

        public RandomSpawner randomSpawner;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            counterText.text = counter.ToString();           
        }

        public void leftMovement()
        {
            if (counter > 0)
            {
                counter --;
            }
        }
        public void rightMovement()
        {
            counter++;
        }
        public void actionMovement()
        {
            Debug.Log(end);

            if (counter == randomSpawner.counterEnd)
            {
                end = true;
            }
            else
            {
                end = false;
            }
        }
    }
}
