using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paul
{

    public class ColorSwitch : MonoBehaviour
    {
        public Boite boite;

        public Material Material1;
        public Material Material2;
        public GameObject Object;

        

        
        public bool checkCouleur2;

        void Start()
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
            checkCouleur2 = false;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void RightInput()
        {
            Object.GetComponent<MeshRenderer>().material = Material2;

            checkCouleur2 = false;
        }

        public void LeftInput()
        {
            Object.GetComponent<MeshRenderer>().material = Material1;

            checkCouleur2 = true;
        }
    }
}