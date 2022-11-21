using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginSpawnGobelets : MonoBehaviour
{
    public GameObject spawnGobelets;
    public GameObject gobelet;

    public int max;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGobelets()
    {
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < max; j++)
            {
                Instantiate(gobelet, new Vector3(spawnGobelets.transform.position.x, spawnGobelets.transform.position.y, spawnGobelets.transform.position.z), Quaternion.identity);
            }
        }
    }
}
