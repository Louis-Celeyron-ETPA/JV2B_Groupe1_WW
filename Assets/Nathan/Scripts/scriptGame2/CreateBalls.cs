using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class CreateBalls : MonoBehaviour
    {
         ////////////////  VARIABLES  /////////////////
        
        public GameObject objectToSpawn;

        private float spawnerX;
        private float spawnerY;
        private float spawnerZ;

        public float counter;
        public float counterSpawnMax;

        ///////////////////////////////////////////////////

        void Update()
        {
            spawnerX = transform.position.x;
            spawnerY = transform.position.y;
            spawnerZ = transform.position.z;

            counter += Time.deltaTime;

            // spawn de balles tous les X temps

            if (counter >+ counterSpawnMax)
            { 
                counter = 0;
                Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY + 10, spawnerZ - 14), Quaternion.identity);
            }
        }
    }

}