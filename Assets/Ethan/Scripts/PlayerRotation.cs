using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class PlayerRotation : MonoBehaviour
    {
        public Camera cam;
        public AiMove drone;
        public Desks allDesks;

        float rotateSpeed = 1.2f;

        // Start is called before the first frame update
        void Start()
        {
            var randomIndex = Random.Range(0, drone.allPoints.Count);
            var randomPoint = drone.allPoints[randomIndex];
            transform.position = new Vector3(randomPoint.theTransform.position.x - 0.1f -1.5f, 0.813f, randomPoint.theTransform.position.z - 1f);
            Debug.Log(randomIndex);
            Destroy(allDesks.desks[randomIndex-1].GetComponent<BoxCollider>());
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void RotateUp()
        {
            cam.transform.eulerAngles += Vector3.right * -rotateSpeed;
        }

        public void RotateDown()
        {
            cam.transform.eulerAngles += Vector3.right * rotateSpeed;
        }

        public void RotateRight()
        {
            cam.transform.eulerAngles += Vector3.up * rotateSpeed;
        }

        public void RotateLeft()
        {
            cam.transform.eulerAngles += Vector3.up * -rotateSpeed;
        }
    }
}