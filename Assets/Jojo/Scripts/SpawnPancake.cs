using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class SpawnPancake : MonoBehaviour
    {
        //********* Init des variables *****************
        public GameObject Pancake;
        private float compteur;
        public int cooldown;
        //**********************************************
        //************ Au lancement ********************
        void Start()
        {
            compteur = cooldown;
        }
        //**********************************************
        //*************** Pour chaque frame ************
        void Update()
        {
            if (compteur > 0)
            {
                compteur -= Time.deltaTime;     // tout les X temps
            }else
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-5f, 5f), transform.position.y, -6.8f);  //Position aléatoire
                Quaternion RotatPancake = Quaternion.Euler(90,0,0);                                                           // rotate de la pancake
                Instantiate(Pancake, randomSpawnPosition, RotatPancake);        //creation de la pancake
                compteur = cooldown;        //reset cooldown
            }
        }
        //**********************************************
    }
}
