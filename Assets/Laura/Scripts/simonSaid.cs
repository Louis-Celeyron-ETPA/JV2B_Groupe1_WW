using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{
public class simonSaid : MonoBehaviour
{
        public GameObject FlecheH;
        public GameObject FlecheB;
        public GameObject FlecheD;
        public GameObject FlecheG;
        public List<int> Simon;
        private int choix;
        private int limit;
    // Start is called before the first frame update
    void Start()
    {
        limit = 4; 
        for (int i = 0; i < limit; i++)
        {
            choix = Random.Range(1, 5);
            Simon.Add(choix);
            print(Simon);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
}
