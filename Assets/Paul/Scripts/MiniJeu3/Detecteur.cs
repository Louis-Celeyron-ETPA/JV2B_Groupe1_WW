using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Paul
{
    public class Detecteur : MonoBehaviour
    {

        public Boite boite;
        public GameObject CoucouDeFou;
        public ColorSwitch colorSwitch;
        public bool stopApresUn;

        public int gagner;
        // Start is called before the first frame update
        void Start()
        {
            boite = null;
            stopApresUn = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                OnSpace();
            }
        }

        public void OnSpace()
        {
            if(boite != null)
            {
                Debug.Log("boite");
                Debug.Log(colorSwitch.checkCouleur2);
                Debug.Log(boite.checkCouleur);

                if (colorSwitch.checkCouleur2 == boite.checkCouleur)
                {
                    Debug.Log("yooooooooo");
                    if (stopApresUn == true)
                    {
                        gagner = gagner + 1;
                        stopApresUn = false;
                    }
                }
            }
        }

        private void OnTriggerEnter(Collider collider)
        {
            stopApresUn = true;
            boite = collider.GetComponent<Boite>();
        }

        private void OnTriggerExit(Collider collider)
        {
            boite = null;
        }
    }
}