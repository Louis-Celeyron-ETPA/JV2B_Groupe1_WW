using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> spawnerLeft;
    public List<GameObject> spawnerRight;
    public float random;

    public GameObject objectToSpawn;

    public float spawnerX;
    public float spawnerY;
    public float spawnerZ;
    // Start is called before the first frame update
    void Start()
    {

        for (int t = 0;t < spawnerLeft.Count; t++)
        {
            random = Random.Range(0f, 1f);

            if (random < 0.5f)
            {
                spawnerX = spawnerLeft[t].transform.position.x;
                spawnerY = spawnerLeft[t].transform.position.y;
                spawnerZ = spawnerLeft[t].transform.position.z;
            }
            if (random > 0.5f)
            {
                spawnerX = spawnerRight[t].transform.position.x;
                spawnerY = spawnerRight[t].transform.position.y;
                spawnerZ = spawnerRight[t].transform.position.z;
            }
            Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY, spawnerZ), Quaternion.identity);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
