using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> spawner;
    public GameObject objectToSpawn;

    private float spawnerX;
    private float spawnerY;
    private float spawnerZ;

    private float spawnOrNot;

    public int counterEnd;

    void Start()
    {
        for (int t = 0; t < spawner.Count; t++)
        {
            spawnOrNot = Random.Range(0f, 1f);

            if (spawnOrNot <= 0.5)
            {
                spawnerX = spawner[t].transform.position.x;
                spawnerY = spawner[t].transform.position.y;
                spawnerZ = spawner[t].transform.position.z;
                Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY, spawnerZ), Quaternion.identity);
                counterEnd++;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
