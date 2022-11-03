using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
        public class CubeRespawn : MonoBehaviour
    {

        public InputMini1 player;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                player.respawn = true;
            }
        }
        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                player.respawn = false;
            }
        }
    }
}
