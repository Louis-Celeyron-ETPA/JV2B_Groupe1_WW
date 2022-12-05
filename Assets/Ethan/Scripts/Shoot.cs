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

        // Autres
        public LineRenderer lr;
        float rotationSpeed = 0.3f;               

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            lr.positionCount = 2;
            lr.SetPosition(0, transform.position - new Vector3(0, 0.1f, 0)); //Origin
            lr.SetPosition(1, transform.position + transform.forward * 2);//Origin+direction*longueur
        }

        public void ShootBullet()
        {
            GameObject ball = Instantiate(ballPrefab, tip.transform.position, Quaternion.identity) as GameObject;
            ball.GetComponent<Rigidbody>().velocity = tip.transform.forward*force;       
        }

        public void Left()
        {
            transform.eulerAngles += new Vector3(0, -rotationSpeed, 0);
        }

        public void Right()
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }

        public void Up()
        {
            transform.eulerAngles += new Vector3(-rotationSpeed, 0, 0);
        }

        public void Down()
        {
            transform.eulerAngles += new Vector3(rotationSpeed, 0, 0);
        }
    }
}
