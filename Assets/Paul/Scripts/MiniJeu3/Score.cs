using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paul
{
    public class Score : MonoBehaviour
    {
        public Text colorChose;
        public Detecteur detecteur;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
            
            colorChose.text = detecteur.gagner.ToString();
        }
    }
}