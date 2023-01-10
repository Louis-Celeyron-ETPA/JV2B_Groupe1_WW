using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{ 
    public class falling_flag : MonoBehaviour
    {
        public Rigidbody rgbd;
        public Vector3 initialPosition;
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
            transform.position += new Vector3(0, 1.5f, 0);
            Debug.Log("il monte");
            StartCoroutine(WaitToRelaunchPhysiscs());
        }

        private IEnumerator WaitToRelaunchPhysiscs()
        {
            rgbd.velocity = Vector3.zero;
            yield return new WaitForSeconds(0.000001f);

        }

    }
}
