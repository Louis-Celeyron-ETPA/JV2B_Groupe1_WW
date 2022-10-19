using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluve
{
    public class CreateBalls : MonoBehaviour
    {
        public GameObject objectToSpawn;

        private float spawnerX;
        private float spawnerY;
        private float spawnerZ;

        private int counter;
        public int counterSpawnMax;

        void Start()
        {
          
        }

        // Update is called once per frame
        void Update()
        {
            spawnerX = transform.position.x;
            spawnerY = transform.position.y;
            spawnerZ = transform.position.z;

            counter++;

            if (counter >+ counterSpawnMax)
            { 
                counter = 0;
                Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY + 10, spawnerZ - 14), Quaternion.identity);
            }
        }
    }

}
