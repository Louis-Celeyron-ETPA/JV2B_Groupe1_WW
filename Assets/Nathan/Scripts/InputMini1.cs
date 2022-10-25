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
            //rb.velocity = rb.velocity.normalized;
            //rb.MovePosition(transform.position + Vector3.left * 0.25f);
            

            if (Input.GetKey(KeyCode.Z))
            {
                rb.velocity = Vector3.forward * speed;
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = -Vector3.forward * speed;
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.Q))
            {
                rb.velocity = -Vector3.right * speed;
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = Vector3.right * speed;
                if (moveOrDie == true)
                { transform.position = new Vector3(startX, startY, startZ); }
            }

            if (Input.GetKeyUp(KeyCode.Z) && Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.Q) && Input.GetKeyUp(KeyCode.D))
            {
                rb.velocity = Vector3.forward * 0;
                rb.velocity = Vector3.right * 0;
                rb.velocity = -Vector3.forward * 0;
                rb.velocity = -Vector3.right * 0;
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
