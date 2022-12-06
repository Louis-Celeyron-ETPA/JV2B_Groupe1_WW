using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class taper : MonoBehaviour
    {
        public Transform initialParent;
        public SpriteRenderer comboti;
        public Sprite combo1;
        public Sprite combo2;
        public Sprite combo3;
        private Vector3 rot;
        private float baseRX;
        private float baseRY;
        private float baseRZ;
        public int points = 0;
        private bool inputtaper = false;
        public int combo = 0;
        public float angle = 60;
        public float timer;
        public float limita = 5f;
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
            timer += Time.deltaTime;
            if (timer >= limita) { combo = 0; timer = 0; }
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
                    Debug.Log("TAP");
                    combo+=1;
                    comboti.sprite = combo1;
                }
                if (combo <= 10)
                {
                    inputtaper = true;
                    points += 5;
                    Debug.Log("BOUM");
                    combo += 1;
                    comboti.sprite = combo2;
                }
                if (combo >= 10)
                {
                    inputtaper = true;
                    points += 10;
                    Debug.Log("KABOUM");
                    comboti.sprite = combo3;
                }
                timer = 0;
            }
        }
        public void ResetTape()
        {
            inputtaper = false;
            rot = new Vector3(baseRX, baseRY,baseRZ);
            initialParent.eulerAngles = rot;
            comboti.sprite = combo1;
        }

    }
}
