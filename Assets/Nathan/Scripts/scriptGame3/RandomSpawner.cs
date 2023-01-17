using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluves
{
    public class RandomSpawner : MonoBehaviour
    {
        ////////////////  VARIABLES  /////////////////

        public List<GameObject> spawner;
        public GameObject objectToSpawn;
        public Transform parent;

        private float spawnerX;
        private float spawnerY;
        private float spawnerZ;

        private float spawnOrNot;
        public float spawnRate;

        public int counterEnd;

        ///////////////////////////////////////////////////

        void Start()
        {
            // fait spawn les objets à compter aléatoirement avec une chance que je définit dans l'ispecteur

            for (int t = 0; t < spawner.Count; t++)
            {
                spawnOrNot = Random.Range(0f, 1f);

                if (spawnOrNot <= spawnRate / 100F)
                {
                    spawnerX = spawner[t].transform.position.x;
                    spawnerY = spawner[t].transform.position.y;
                    spawnerZ = spawner[t].transform.position.z;
                    Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY , spawnerZ), Quaternion.Euler(-90,0,-90), parent);
                    counterEnd++;
                }

            }
        }
    }
}
