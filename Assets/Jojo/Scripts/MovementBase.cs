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
            rt.anchoredPosition.y / Camera.main.pixelHeight * -1,
            Camera.main.nearClipPlane);
            var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);

            var positionDansLeMonde = new Vector3(convertedPosition.x, -convertedPosition.y, convertedPosition.z);

            Debug.DrawRay(transform.position, positionDansLeMonde);

            if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var other))
            {
                if (other.transform.tag == "Voleur")
                {
                    Destroy(other.transform.gameObject);
                }
            }
        }

    }
    
}