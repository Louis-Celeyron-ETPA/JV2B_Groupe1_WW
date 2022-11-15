using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class Victoire : MonoBehaviour
    {
        public Text text;
        public float timer;
        // Start is called before the first frame update
        void Start()
        {
            timer = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > 15f)
            {
                Debug.Log("Défaite");
                text.text = "Défaite";
            }
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Victoire");
                Debug.Log(text .gameObject);
                text.text = "Victoire";
            }
        }
    }
}