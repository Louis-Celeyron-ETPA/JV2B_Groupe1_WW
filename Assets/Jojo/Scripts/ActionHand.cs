using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jojo
{
    public class ActionHand : MonoBehaviour
    {
        //********* Init des variables *****************
        Rigidbody rb;
        public GameObject Hand;
        public GameObject TasseObject;
        Vector3 PoseServ;
        Vector3 PoseStart;
        Vector3 PoseReload;
        float PourcentageLerp; 
        float PourcentageLerp2; 
        bool StartLerp=false;
        bool InGoBack= false;
        // ************************************

        void Start()
        {   
            //************ Au lancement *************
            rb = GetComponent<Rigidbody>();
            PoseServ= new Vector3 (0.180000007f,3.27999997f,-9.14999962f);      //definition des variables / position de base
            PoseReload = new Vector3 (0.180000007f,3.27999997f,-11.3999996f);
            PourcentageLerp = 0;
            PourcentageLerp2 = 0;
            PoseStart = transform.position;
            //************************************
        }

        void Update()
        {
            //*************** Pour chaque frame *******************************
            if(StartLerp==true){
            Hand.transform.position = Vector3.Lerp(PoseStart,PoseServ,PourcentageLerp);    //déplacement de la position du debut vers la position pour servir
            PourcentageLerp += 0.02f;
            if(PourcentageLerp >= 1){
                StartLerp=false;        //quand la main arrive a la position du serveur alors ...
                PourcentageLerp=0;
            }
            }

            if(StartLerp==false && TasseObject.activeSelf && InGoBack==false){
                if(transform.position != PoseStart){
                Hand.transform.position = Vector3.Lerp(PoseServ,PoseStart,PourcentageLerp);                // déplacement de la position du service vers la position du début si 
                PourcentageLerp += 0.02f;                                                                   // la tasse n'a pas etait servie
                if(PourcentageLerp >= 1){   
                    PourcentageLerp=0;
                }
            }
            }
            
            
            if(transform.position != PoseStart && InGoBack==true){                              //quand la main est hors champ la remettre a la position du debut
                Hand.transform.position = Vector3.Lerp(PoseReload,PoseStart,PourcentageLerp);   
                PourcentageLerp += 0.02f;
                if(PourcentageLerp >= 1){
                        PourcentageLerp=0;
                        InGoBack = false;
                }
            }
            
            if(StartLerp==false && TasseObject.activeSelf == false ){
                PourcentageLerp=0;
                if(transform.position != PoseReload){                                                               // quand la tasse est servie mettre la main hors champ pour la remmetre
                Hand.transform.position = Vector3.Lerp(PoseServ,PoseReload,PourcentageLerp2);       
                PourcentageLerp2 += 0.02f;
                if(PourcentageLerp2 >= 1){
                    PourcentageLerp2=0;
                    TasseObject.gameObject.SetActive(true);              // réactiver la tasse quand main hors champ
                    InGoBack = true;
                }
            }
            }
            //**************************************
        }

        // Fonction Action joueur
        public void ActionServir()
        {
            if(Hand.transform.position == PoseStart){       // quand la touche d'action est down faire le service
                StartLerp = true;
            }
        }
        //******************
    }
}