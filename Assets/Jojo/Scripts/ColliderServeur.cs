using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class ColliderServeur : MonoBehaviour
    {
        public GameObject Tasse;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void OnTriggerEnter(Collider other){
            if(other.gameObject.tag == "TasseTag"){
                other.gameObject.SetActive(false);
            }
        }
    }
}