using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public float speed = 20f;

    public GameObject objectToSpawn;

    private float spawnerX;
    private float spawnerY;
    private float spawnerZ;

    private int counter;
    public int counterSpawnMax;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        spawnerX = transform.position.x;
        spawnerY = transform.position.y;
        spawnerZ = transform.position.z;

        

        counter++;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter = 0;
            Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY , spawnerZ), Quaternion.identity);

        }
    }
}
