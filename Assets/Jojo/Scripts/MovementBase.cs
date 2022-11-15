using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class MovementBase : MonoBehaviour
    {
        public RectTransform rt;
        float speed = 8f;

        void Start()
        {

        }

        void Update()
        {

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

        public void Action()
        {
            var positionTemporaire = new Vector3(
            rt.anchoredPosition.x / Camera.main.pixelWidth,
            rt.anchoredPosition.y / Camera.main.pixelHeight,
            Camera.main.nearClipPlane);


            var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);
            var pla = new Vector3(Camera.main.transform.position.x, -Camera.main.transform.position.y, Camera.main.transform.position.z) - convertedPosition;


            Debug.Log(Camera.main.ViewportToWorldPoint(convertedPosition));

            //Debug.DrawRay(convertedPosition,Camera.main.transform.forward * 1000);
            Debug.DrawRay(Camera.main.transform.position, pla.normalized* -1000);
          
            if (Physics.Raycast(Camera.main.transform.position, -pla.normalized, out var other))
            {
                Debug.Log(other.transform);
                if (other.transform.tag == "Voleur")
                {
                    Destroy(other.transform.gameObject);
                }
            }
        }
    }
    
}