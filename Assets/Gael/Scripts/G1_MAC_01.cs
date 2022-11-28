using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Gael
{
    
    public class G1_MAC_01 : MonoBehaviour
    {
        public float counter;

        public Transform tra;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                tra.position += new Vector3(0f, 0.02f, 0f);
            }

            counter++;
            if (counter > 15f)
            {

            }


        }
    }
}
