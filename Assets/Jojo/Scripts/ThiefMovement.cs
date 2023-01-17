using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{

    public class ThiefMovement : MonoBehaviour
    {
        //********* Init des variables *****************
        public bool BigMove;
        public bool SmallMove;
        float pourcentageM = 0f;
        public string Direction;
        float pourcentageM2 = 0f;
        bool FinMove1 = false;
        Vector3 PoseBase;
        Vector3 PoseFin;
        Vector3 PoseBaseP;
        Vector3 PoseFinPB;
        Vector3 PoseFinPS;
        public float[] SpeedThiefBig;
        public float GetSpeedThiefBig(){
            return SpeedThiefBig[0];       //difficulté
        }

        public float[] SpeedThiefSmall;
        public float GetSpeedThiefSmall(){
            return SpeedThiefSmall[0];       //difficulté
        }       
        //**********************************************
        //************ Au lancement ********************
        void Start()
        {
            BigMove = false;
            SmallMove = false;
            PoseBaseP = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            if (Direction == "droite")
            {
                PoseFinPB = transform.position + transform.up * 6f;         //set des positions des voleurs
                PoseFinPS = transform.position + transform.up * 2f;
            }
            if (Direction == "gauche")
            {
                PoseFinPB = transform.position + transform.up * 6f;
                PoseFinPS = transform.position + transform.up * 2f;
            }

        }
        //**********************************************
        //*************** Pour chaque frame ************
        void Update()
        {
            if (BigMove == true && SmallMove == false)
            {
                MovementVoleur(GetSpeedThiefBig());         //lancement fonction mouvement
            }
            if (SmallMove == true && BigMove == false)
            {
                MovementVoleur(GetSpeedThiefSmall());
            }
        }
        //**********************************************
        //***************Fonction movement voleur*******
        private void MovementVoleur( float PourcentageMouvement){
                if (FinMove1 == false)
                {
                    if(BigMove==true){
                    transform.position = Vector3.Lerp(PoseBaseP, PoseFinPB, pourcentageM);
                    }
                    if(SmallMove==true){
                        transform.position = Vector3.Lerp(PoseBaseP, PoseFinPS, pourcentageM);          
                    }
                    pourcentageM += PourcentageMouvement;
                }
                if (pourcentageM >= 1f)
                {
                    pourcentageM = 0f;
                    PoseFin = PoseBaseP;
                    PoseBase = transform.position;
                    FinMove1 = true;
                }                                                                                               //Transition de mouvement entre deux positions
                if (FinMove1 == true)
                {       
                    transform.position = Vector3.Lerp(PoseBase, PoseFin, pourcentageM2);
                    pourcentageM2 += PourcentageMouvement;
                }
                if (pourcentageM2 >= 1f)
                {
                    pourcentageM2 = 0f;
                    if(BigMove==true){
                        BigMove = false;
                    }
                    if(SmallMove==true){
                       SmallMove = false;
                    }
                    FinMove1 = false;
                    PoseBase = PoseBaseP;
                    PoseFin = PoseFinPS;
                }
        }
        //*******************************************
    }

}
