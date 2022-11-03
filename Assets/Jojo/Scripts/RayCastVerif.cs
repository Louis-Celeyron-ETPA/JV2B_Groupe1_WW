using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jojo
{
    public class RayCastVerif : MonoBehaviour
{
    public Vector3 direction;
        public LayerMask masklol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Physics.Raycast(transform.position, direction,out var other, masklol))
            {
                Debug.Log(other);
                if (other.transform.tag == "Voleur")
                {
                    Destroy(other.transform.gameObject);
                }
            }

            Debug.DrawRay(transform.position, direction);
    }
}

}
