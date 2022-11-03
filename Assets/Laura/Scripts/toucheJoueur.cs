using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class toucheJoueur : MonoBehaviour
    {
        public MeshRenderer FH;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            FlecheH();
        }
        void FlecheH()
        {
            Debug.Log(FH.materials);
        }
    }

            
}
