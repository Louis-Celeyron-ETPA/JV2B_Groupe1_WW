using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Paul
{

    public class SpawnBoite : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public float counter;
        public int counterMax;

        // Start is called before the first frame update
        void Start()
        {
            counterMax = 90;
            counter = 85;
        }

        // Update is called once per frame
        void Update()
        {
            counter++;
            if (counter > counterMax)
            {
                Instantiate(objectToSpawn, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                counter = 0;
                counterMax = counterMax - 3;
            }
        }
    }
}