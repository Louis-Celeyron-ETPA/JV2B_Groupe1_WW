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

        }

        public void ActionInput()
        {
            OnSpace();
        }

        // La machine check si la boite est dans sa zone d'effet, puis si elle est de la bonne couleur, puis si t'appuie sur le bouton d'actionS
        public void OnSpace()
        {
            if(boite != null)
            {
               

                if (colorSwitch.checkCouleur2 == boite.checkCouleur)
                {
                    
                    if (stopApresUn == true)
                    {
                        gagner = gagner + 1;
                        stopApresUn = false;
                    }
                }
            }
        }

        // DEtecte quand la boite rentre et sort de la zone d'effet de la machine
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