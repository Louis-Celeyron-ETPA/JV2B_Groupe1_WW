using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jojo
{
    public class ActionHand : MonoBehaviour
    {
        Rigidbody rb;
        public GameObject Hand;
        Vector3 PoseServ;
        Vector3 PoseStart;
        float PourcentageLerp; 
        bool StartLerp=false;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            PoseServ= new Vector3 (0.180000007f,3.27999997f,-9.14999962f);
            PourcentageLerp = 0;
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

            if(StartLerp==false){
                if(transform.position != PoseStart){
                Hand.transform.position = Vector3.Lerp(PoseServ,PoseStart,PourcentageLerp);
                PourcentageLerp += 0.02f;
                if(PourcentageLerp >= 1){
                    PourcentageLerp=0;
                }
            }
            }
        }

        public void ActionServir()
        {
            if(transform.position == PoseStart){
                StartLerp = true;
            }
        }

    }
}