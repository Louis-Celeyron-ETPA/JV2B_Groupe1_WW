using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform []parents;
    public Vector3 initialPosition;
    public Vector3 targetPosition;
    public Transform target;
    public bool shouldGoToTarget;
    public float delta;

    // Update is called once per frame
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, new Vector3(0, 1, 9), Quaternion.identity, parents[Random.Range(0,4)]);
        }

        
         targetPosition = target.position;
         initialPosition = transform.position;
         delta = 0;
         shouldGoToTarget = true;
        

        if (shouldGoToTarget)
        {
            delta += Time.deltaTime;
            transform.position = Vector3.Lerp(initialPosition, targetPosition, delta);
        }

        if (delta >= 1)
        {
            shouldGoToTarget = false;
            delta = 0;
        }
    }
}

