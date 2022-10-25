using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{
    public class voiture : MonoBehaviour
    {
        public Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            rb.AddForce(Vector3.forward * 500);
            if (Input.GetKey(KeyCode.Q))
            {
                rb.AddForce(Vector3.left * 200);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * 200);
            }
        }
        void OnCollisionEnter(Collision collision)
        {
            //Check for a match with the specified name on any GameObject that collides with your GameObject
            if (collision.gameObject.name == "MyGameObjectName")
            {
                //If the GameObject's name matches the one you suggest, output this message in the console
                Debug.Log("Do something here");
            }

            //Check for a match with the specific tag on any GameObject that collides with your GameObject
            if (collision.gameObject.tag == "MyGameObjectTag")
            {
                //If the GameObject has the same tag as specified, output this message in the console
                Debug.Log("Do something else here");
            }
        }
    }

}