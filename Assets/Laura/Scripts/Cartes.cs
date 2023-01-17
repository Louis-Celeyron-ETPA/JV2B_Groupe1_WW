using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class Cartes : MonoBehaviour
    {
        public MeshRenderer mr;
        public Vector3 initialPos;
        private void Awake()
        {
            initialPos = transform.position;
        }
        public void ChangeColor(Color color)
        {
            mr.material.color = color;  
        }
        public void ChangePosition()
        {
            transform.position += transform.forward * -0.5f;
        }
        public void ResetPosition()
        {
            transform.position = initialPos;

        }
    }
}
