using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class InputMini1 : MonoBehaviour
    {

        public float speed = 125;
        public Rigidbody rb;

        public StopMove stop;

        public bool moveOrDie = false;

        public float startX;
        public float startY;
        public float startZ;

        public bool respawn = false;

        void Start()
        {
            startX = transform.position.x;
            startY = transform.position.y;
            startZ = transform.position.z;
        }

        void Update()
        {
            rb.velocity = rb.velocity.normalized;
            //rb.MovePosition(transform.position + Vector3.left * 0.25f);

            if (stop.dontMove == true)
            {
                moveOrDie = true;
            }
            else
            {
                moveOrDie = false;
            }

            if (respawn == true)
            {
                transform.position = new Vector3(startX, startY, startZ);
            }
        }

        public void leftMovement()
        {
            rb.AddForce(-Vector3.right * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void rightMovement()
        {
            rb.AddForce(Vector3.right * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void upMovement()
        {
            rb.AddForce(Vector3.forward * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }
        public void downMovement()
        {
            rb.AddForce(-Vector3.forward * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
        }

    }
}
