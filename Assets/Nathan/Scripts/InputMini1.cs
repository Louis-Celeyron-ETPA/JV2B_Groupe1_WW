using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluve
{
    public class InputMini1 : MonoBehaviour
    {

        public float speed = 125;
        public float speedJump;
        public Rigidbody rb;

        public CubeLast cubeLast;

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

            Physics.gravity = new Vector3(0, -300, 0);
            if (Input.GetKey(KeyCode.Z))
            {
                rb.AddForce(Vector3.forward * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(-Vector3.forward * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.Q))
            {
                rb.AddForce(-Vector3.right * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * (speed));
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }

            if (cubeLast.dontMove == true)
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

    }
}
