using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{
    public class turn : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = Vector3.zero;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = Vector3.up * 180;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.eulerAngles = Vector3.up * 270;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = Vector3.up * 90;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            //Check for a match with the specified name on any GameObject that collides with your GameObject
            
        }
    }
}
