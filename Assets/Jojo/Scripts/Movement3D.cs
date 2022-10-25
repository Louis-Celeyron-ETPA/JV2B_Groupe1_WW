using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class Movement3D : MonoBehaviour
    {
        float speed = 0.13f;
        public Transform TF;

        void Start()
        {
            {

            }
        }

        void Update()
        {
            if (TF.position.x > 4.24)
            {
                TF.position = new Vector3(-3.9f,0.52f,-6.8f);
            }
            if (TF.position.x < -4.24)
            {
                TF.position = new Vector3(3.9f, 0.52f, -6.8f);
            }

        }

        public void RightMove(){
            TF.localPosition += TF.right * speed;
        }
        
        public void LeftMove(){
            TF.localPosition += TF.right * -speed;
        }

    }
    
}