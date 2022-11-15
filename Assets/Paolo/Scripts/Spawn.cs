using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform []parents;
    public Transform target;



    // Update is called once per frame
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            pokeboulle pokeball = Instantiate(objectToSpawn, parents[Random.Range(0, 4)]).GetComponent<pokeboulle>();
            pokeball.tragrt = target;
        }

        
         
    }
}

