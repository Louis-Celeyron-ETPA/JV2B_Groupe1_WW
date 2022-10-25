using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Gael
{
    public class G1_MAC_02 : MonoBehaviour
    {
        
        public bool touch;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (touch == true)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "upperteeth")
            {
             transform.localScale -= new Vector3(0f, 0.1f, 0f);
            }
        }
    }
}

//if (gameObject.tag.Equals("upper") == true)