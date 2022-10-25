using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public float speed = 40f;

    public GameObject objectToSpawn;

    public float spawnerX;
    public float spawnerY;
    public float spawnerZ;

    public float rotationX;
    public float rotationY;
    public float rotationZ;

    private int counter;
    public int counterSpawnMax;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);





        if (transform.rotation.z >= 0.5)
        {
            speed = -40f;
        }
        if(transform.rotation.z <= -0.5)
        {
            speed = 40f;
        }
        spawnerX = transform.position.x;
        spawnerY = transform.position.y;
        spawnerZ = transform.position.z;

        rotationX = transform.rotation.x;
        rotationY = transform.rotation.y;
        rotationZ = transform.rotation.z;

        counter++;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter = 0;
            Instantiate(objectToSpawn, new Vector3(spawnerX, spawnerY , spawnerZ), Quaternion.identity);

        }
    }
}
