using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class toucheJoueur : MonoBehaviour
    {
        public MeshRenderer FH;
        public Material colorR;
        public Material colorV;
        public Material colorJ;
        public Material colorB;
        public Material []listR;
        public Material []listV;
        public Material []listJ;
        public Material []listB;
        public List<int> valeurs;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void FlecheH()
        {
            FH.materials = listR;
            valeurs.Add(1);
            Debug.Log("Rouge");
        }
        public void FlecheD()
        {
            FH.materials = listV;
            valeurs.Add(3);
            Debug.Log("Vert");
        }
        public void FlecheB()
        {
            FH.materials = listJ;
            valeurs.Add(2);
            Debug.Log("Jaune");
        }
        public void FlecheG()
        {
            FH.materials = listB;
            valeurs.Add(4);
            Debug.Log("Bleu");
        }
    }


}
