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
            var parent = parents[Random.Range(0, 4)];
            pokeboulle pokeball = Instantiate(objectToSpawn, parent,false).GetComponent<pokeboulle>();
            pokeball.transform.localPosition = Vector3.zero;
            pokeball.transform.localEulerAngles = Vector3.zero;
            pokeball.tragrt = target;
        }

        
         
    }
}

