using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class Shoot : MonoBehaviour
    {
        // Normal
        public GameObject ballPrefab;
        float force = 20f;
        public GameObject tip;
        float speed = 0.03f;               

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ShootBullet()
        {
            GameObject ball = Instantiate(ballPrefab, tip.transform.position, Quaternion.identity) as GameObject;
            ball.GetComponent<Rigidbody>().velocity = tip.transform.forward*force;       
        }

        public void Left()
        {
            transform.position += new Vector3(-speed, 0, 0);
        }

        public void Right()
        {
            transform.position += new Vector3(speed, 0, 0);
        }

        public void Up()
        {
            transform.position += new Vector3(0, speed, 0);
        }

        public void Down()
        {
            transform.position += new Vector3(0, -speed, 0);
        }
    }
}
