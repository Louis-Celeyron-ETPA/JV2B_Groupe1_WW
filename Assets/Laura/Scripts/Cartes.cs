using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class Cartes : MonoBehaviour
    {
        public MeshRenderer Matiere;
        public Vector3 InitialPos;
        private void Awake()
        {
            InitialPos = transform.position;
        }
        public void ChangeColor(Color color)
        {
            Matiere.material.color = color;  
        }
        public void ChangePosition()
        {
            transform.position += transform.forward * -0.5f;
        }
        public void ResetPosition()
        {
            transform.position = InitialPos;

        }
    }
}
