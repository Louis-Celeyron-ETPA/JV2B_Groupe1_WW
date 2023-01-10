using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{
    public class Spawn : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public Transform[] parents;
        public Transform target;
        public float interval = 0.73f ;
        public float timer;


        // Update is called once per frame
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                SpawnBoule();
                timer = 0;
            }


        }

        private void SpawnBoule()
        {
            var parent = parents[Random.Range(0, 4)];
            pokeboulle pokeball = Instantiate(objectToSpawn, parent, false).GetComponent<pokeboulle>();
            pokeball.transform.localPosition = Vector3.zero;
            pokeball.transform.localEulerAngles = Vector3.zero;
            pokeball.tragrt = target;
        }
    }

}