using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class SpawnPancake : MonoBehaviour
    {
        public GameObject Pancake;
        private float compteur;
        public int cooldown;
        // Start is called before the first frame update
        void Start()
        {
            compteur = cooldown;
        }

        // Update is called once per frame
        void Update()
        {
            if (compteur > 0)
            {
                compteur -= Time.deltaTime;
            }else
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-3f, 3f), transform.position.y, -6.8f);
                Quaternion RotatPancake = Quaternion.Euler(90,0,0);
                Instantiate(Pancake, randomSpawnPosition, RotatPancake);
                compteur = cooldown;
            }
        }
    }
}
