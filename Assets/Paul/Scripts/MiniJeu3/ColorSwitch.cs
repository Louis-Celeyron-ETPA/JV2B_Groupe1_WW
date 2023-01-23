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
            // la machine démarre en couleur 1
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
            checkCouleur2 = true;
        }

        void Update()
        {

        }
        // Change la couleur de la machine
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