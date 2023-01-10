using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{ 
    public class box_win_condition : MonoBehaviour
    {
        // Start is called before the first frame update

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update(Collision collisionInfo)
        {
            // Debug-draw all contact points and normals
            foreach (ContactPoint contact in collisionInfo.contacts)
            {
                Debug.Log("oui");

            }
        }

        
    }
}
