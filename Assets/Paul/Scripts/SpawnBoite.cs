using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoite : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float counter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter > 800f)
        {
            Instantiate(objectToSpawn, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            counter = 0;
        }
    }
}
