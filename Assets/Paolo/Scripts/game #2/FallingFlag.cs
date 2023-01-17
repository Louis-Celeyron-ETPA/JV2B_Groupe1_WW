using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{ 
    public class FallingFlag : MonoBehaviour
    {
        public Rigidbody rgbd;
        public Vector3 initialPosition;
        public float maxHeight=0.9f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MONTE();
            }

            if (rgbd.velocity.y<=-5)
            {
                rgbd.velocity = Vector3.down * 5;
            }
        }

        private void MONTE()
        {
            var tempPosition = transform.position + new Vector3(0, 1.5f, 0);
            if(tempPosition.y>maxHeight)
            {
                transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
                Debug.Log(transform.position.y);
            }
            else
            {
                transform.position = tempPosition;
            }

            Debug.Log("il monte");
            StartCoroutine(WaitToRelaunchPhysiscs());
        }

        private IEnumerator WaitToRelaunchPhysiscs()
        {
            rgbd.velocity = Vector3.zero;
            yield return new WaitForEndOfFrame();

        }

    }
}
