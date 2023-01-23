using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pediluves
{
    public class StopMove : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////
        
        public List<GameObject> cubeList;
        private float counter;
        private float counterReturn;

        private int i;
        private int nbrCubeRouge;

        public bool dontMove = false;

        public InputMini1 inputManag;

        public float counterMax;
        public float counterReturnMax;

        public Color color;
        public Color colorLast;
        public Color colorFirst;

        public float[] vitesseStop;

        public float GetVitesseMax()
        {
           return vitesseStop[ManagerManager.DifficultyManager.GetDifficulty()];
        }

        ///////////////////////////////////////////////////

        void Start()
            {

                for (int t = 0; t < 7; t++)
                {
                    cubeList[t].GetComponent<Renderer>().material.color = colorFirst;
                }
            }

            void Update()
            {
                // 1 cubes de plus qui s'allume pour avancer le timer au niveau du visuel

                if (dontMove == false)
                {
                    counter += Time.deltaTime;

                    if (counter >= GetVitesseMax())
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

                // si tous les cubes sont allumés, le dernier sera le boutton stop et le joueur ne doit plu se déplacer

                if (nbrCubeRouge == 7)
                {
                    nbrCubeRouge = 0;
                    counter = 0;
                    i = 0;
                    dontMove = true;
                }

                // temps pendant lequel le joueur ne doit pas bouger

                if (dontMove == true)
                {
                    counterReturn += Time.deltaTime;

                    if (counterReturn >= counterReturnMax)
                    {
                        for (int t = 0; t < 7; t++)
                        {
                            cubeList[t].GetComponent<Renderer>().material.color = colorFirst;
                        }
                        counterReturn = 0;
                        dontMove = false;
                    }
                }

            }

        }
    }