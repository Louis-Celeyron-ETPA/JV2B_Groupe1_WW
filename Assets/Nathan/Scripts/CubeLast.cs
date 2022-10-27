using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pediluve
{
    public class Stop : MonoBehaviour
    {
        public List<GameObject> cubeList;
        private int counter;
        private int counterReturn;

        private int i;
        private int nbrCubeRouge;

        public bool dontMove = false;

        public InputMini1 inputManag;

        public int counterMax;
        public int counterReturnMax;

        public Color color;
        public Color colorLast;

        void Start()
        {
        }

        void Update()
        {
            if (dontMove == false)
            {
                counter++;

                if (counter == counterMax)
                {
                    if (i == 6)
                    {
                        cubeList[i].GetComponent<Renderer>().material.color = colorLast;
                    }
                    else
                    {
                        cubeList[i].GetComponent<Renderer>().material.color = color;
                    }
                    i++;
                    counter = 0;
                    nbrCubeRouge++;
                }
            }

            if (nbrCubeRouge == 7)
            {
                nbrCubeRouge = 0;
                counter = 0;
                i = 0;
                dontMove = true;
            }

            if (dontMove == true)
            {
                counterReturn++;
                if (counterReturn == counterReturnMax)
                {
                    for (int t = 0; t < 7; t++)
                    {
                        cubeList[t].GetComponent<Renderer>().material.color = Color.black;
                    }
                    counterReturn = 0;
                    dontMove = false;
                }
            }

        }

    }
}
