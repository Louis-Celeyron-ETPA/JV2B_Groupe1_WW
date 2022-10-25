using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class MovementBase : MonoBehaviour
    {
        /*
        public KeyCode droite;
        public KeyCode gauche;
        float speed = 0.13f;
        */
        public RectTransform rt;
        float speed = 8f;

        void Start()
        {
            {

            }
        }

        void Update()
        {
            /*
            if (Input.GetKey(droite))
            {
                transform.localPosition += transform.right * speed;
            }
            else if (Input.GetKey(gauche))
            {
                transform.localPosition += transform.right * -speed;
            }

            if (transform.position.x > 4.24)
            {
                transform.position = new Vector3(-3.9f,0.52f,-6.8f);
                Debug.Log("oui");
            }
            if (transform.position.x < -4.24)
            {
                transform.position = new Vector3(3.9f, 0.52f, -6.8f);
                Debug.Log("oui");
            }
            */

        }

        public void RightMove(){
            rt.anchoredPosition += Vector2.right * speed;
        }
        
        public void LeftMove(){
            rt.anchoredPosition -= Vector2.right * speed;
        }

        public void UpMove(){
            rt.anchoredPosition += Vector2.up * speed;
        }

        public void DownMove(){
            rt.anchoredPosition -= Vector2.up * speed;
        }

    }
    
}