using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class MovementBase : MonoBehaviour
    {
        //********* Init des variables *****************
        public RectTransform rt;
        float speed = 15f;
        public int ScoreVoleur;
        public float TimerVoleur=15;
        //**********************************************
        //************ Au lancement ********************
        void Start()
        {
            ScoreVoleur=0;
        }
        //**********************************************
        //*************** Pour chaque frame ************
        void Update()
        {
            TimerVoleur-=Time.deltaTime;
            if(ScoreVoleur>=3){ 
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);     //verif si score atteint si oui alors victoire
            }

            if(TimerVoleur<=0){
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  // verifie si le temps est a zero si oui alors defaite
            }
            
        }
        //**********************************************
        //**************Fonction mouvement**************
        public void RightMove(){
            rt.anchoredPosition += Vector2.right * speed;
        }
        
        public void LeftMove(){
            rt.anchoredPosition -= Vector2.right * speed;
        }

        public void UpMove(){
            rt.anchoredPosition += Vector2.up * speed;
        }

        public void DownMove(){
            rt.anchoredPosition -= Vector2.up * speed;
        }
        //**********************************************
        //*********Fonction Action*********************
        public void Action()
        {
            var positionTemporaire = new Vector3(
            rt.anchoredPosition.x / Camera.main.pixelWidth,
            rt.anchoredPosition.y / Camera.main.pixelHeight,
            Camera.main.nearClipPlane);


            var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);
            var pla = new Vector3(Camera.main.transform.position.x, -Camera.main.transform.position.y, Camera.main.transform.position.z) - convertedPosition;           //calcule pour raycast 


            Debug.Log(Camera.main.ViewportToWorldPoint(convertedPosition));
            Debug.DrawRay(Camera.main.transform.position, pla.normalized* -1000);
          
            if (Physics.Raycast(Camera.main.transform.position, -pla.normalized, out var other))        //lancement d'un raycast
            {
                Debug.Log(other.transform);
                if (other.transform.tag == "Voleur")            //verifie si objet toucher est voleur
                {
                    ScoreVoleur+=1;                                             //ajoute 1 au score et enleve le voleur
                    Destroy(other.transform.gameObject);
                }
            }
        }
        //****************************************
    }
    
}