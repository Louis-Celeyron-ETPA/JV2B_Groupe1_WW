using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class ClientMovement : MonoBehaviour
    {
        Rigidbody rb;
        RectTransform rt;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }


        void Update()
        {
            //*************** Pour chaque frame *******************************
            rb.velocity = Vector3.left * 8;
            if(rb.position.x <= -14.6800003f ){
                rb.position = new Vector3 (13.5900002f,0.150000006f,-0.810000002f);
            }
            //**************************************
        }
    }
}