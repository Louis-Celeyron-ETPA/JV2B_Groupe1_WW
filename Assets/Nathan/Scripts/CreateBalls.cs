using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pediluve
{
    public class CreateBalls : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public Transform parent;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var myobject = Instantiate(objectToSpawn, parent);

                myobject.transform.position = new Vector3(0, -20, 100);
                 

                //Instantiate(objectToSpawn, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity, parent);
            }

        }
    }
}
