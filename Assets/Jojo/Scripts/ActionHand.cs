using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jojo
{
    public class ActionHand : MonoBehaviour
    {
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
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            PoseServ= new Vector3 (0.180000007f,3.27999997f,-9.14999962f);
            PoseReload = new Vector3 (0.180000007f,3.27999997f,-11.3999996f);
            PourcentageLerp = 0;
            PourcentageLerp2 = 0;
            PoseStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if(StartLerp==true){
            Hand.transform.position = Vector3.Lerp(PoseStart,PoseServ,PourcentageLerp);
            PourcentageLerp += 0.02f;
            if(PourcentageLerp >= 1){
                StartLerp=false;
                PourcentageLerp=0;
            }
            }

            if(StartLerp==false && TasseObject.activeSelf && InGoBack==false){
                if(transform.position != PoseStart){
                Hand.transform.position = Vector3.Lerp(PoseServ,PoseStart,PourcentageLerp);
                PourcentageLerp += 0.02f;
                if(PourcentageLerp >= 1){
                    PourcentageLerp=0;
                }
            }
            }
            
            Debug.Log(PourcentageLerp);
            
            if(transform.position != PoseStart && InGoBack==true){
                Hand.transform.position = Vector3.Lerp(PoseReload,PoseStart,PourcentageLerp);
                PourcentageLerp += 0.02f;
                if(PourcentageLerp >= 1){
                        PourcentageLerp=0;
                        InGoBack = false;
                }
            }
            
            if(StartLerp==false && TasseObject.activeSelf == false ){
                PourcentageLerp=0;
                if(transform.position != PoseReload){
                Hand.transform.position = Vector3.Lerp(PoseServ,PoseReload,PourcentageLerp2);
                PourcentageLerp2 += 0.02f;
                if(PourcentageLerp2 >= 1){
                    PourcentageLerp2=0;
                    TasseObject.gameObject.SetActive(true);
                    InGoBack = true;
                }
            }
            }
        }

        public void ActionServir()
        {
            if(Hand.transform.position == PoseStart){
                StartLerp = true;
            }
        }

    }
}