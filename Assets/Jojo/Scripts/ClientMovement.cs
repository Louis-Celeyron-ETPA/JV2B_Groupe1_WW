using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class ClientMovement : MonoBehaviour
    {
        //********* Init des variables *****************
        Rigidbody rb;
        RectTransform rt;
        public int[] VitesseClient;     
        public int GetVitesseClient(){
            return VitesseClient[ManagerManager.DifficultyManager.GetDifficulty()]; //difficulté
        }
        // ***************************************************
        //************ Au lancement **************************
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        // ***************************************************
        //*************** Pour chaque frame *******************************
        void Update()
        {
            rb.velocity = Vector3.left * GetVitesseClient();
            if(rb.position.x <= -14.6800003f ){
                rb.position = new Vector3 (13.5900002f,0.150000006f,-0.810000002f);
            }
        }
        // ***************************************************
    }
}