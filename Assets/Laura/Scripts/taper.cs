using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class taper : MonoBehaviour
    {
        public Transform initialParent;
        private Vector3 rot;
        private float baseRX;
        private float baseRY;
        private float baseRZ;
        public int points = 0;
        private bool inputtaper = false;
        public int combo = 0;
        public float angle = 60;
        // Start is called before the first frame update
        void Start()
        {
            baseRX = -90;
            baseRY = 0;
            baseRZ = 0;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Tape()
        {
            if (inputtaper == false)
            {
                rot = new Vector3(initialParent.eulerAngles.x + angle, initialParent.eulerAngles.y, initialParent.eulerAngles.z);
                initialParent.eulerAngles = rot;
                if (combo <= 5)
                {
                    inputtaper = true;
                    points+= 1;
                    Debug.Log(gameObject);
                    combo+=1;
                }
                if (combo == 5)
                {
                    inputtaper = true;
                    points += 5;
                    Debug.Log("TAP");
                    combo = 0;
                }
            }
        }
        public void ResetTape()
        {
            inputtaper = false;
            rot = new Vector3(baseRX, baseRY,baseRZ);
            initialParent.eulerAngles = rot;
        }

    }
}
