using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Paul
{
    public class Canon : MonoBehaviour
    {
        public float speed = 40f;

        public GameObject objectToSpawn;

        public float spawnerX;
        public float spawnerY;
        public float spawnerZ;

        public float rotationX;
        public float rotationY;
        public float rotationZ;

        private int counter;
        public int counterSpawnMax;

       

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Le canon tourne sur lui même pdt un certain temps avant de tourner, puis il envoie ses coordonées au boulet même si je crois que toutes mes variables x y z ne servent à rien mais j'ai peur de faire buger un truc si j'y touche

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);


            if (transform.rotation.z >= 0.20)
            {
                speed = -40f;
            }
            if (transform.rotation.z <= -0.20)
            {
                speed = 40f;
            }
            spawnerX = transform.position.x;
            spawnerY = transform.position.y;
            spawnerZ = transform.position.z;

            rotationX = transform.rotation.x;
            rotationY = transform.rotation.y;
            rotationZ = transform.rotation.z;

            counter++;

            
            if (counter < 101) 
            {
                counter++;
                
            }

        }

        // fais spawn le boulet
        public void ToucheEspace()
        {
            if (counter > 100)
            {
                counter = 0;
                Instantiate(objectToSpawn, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            }

        }
    }
}