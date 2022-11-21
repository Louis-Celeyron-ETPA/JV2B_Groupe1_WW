using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokeboulle : MonoBehaviour
{
    
    public bool shouldGoToTarget;
    public float delta;
    public Transform tragrt;
    public Vector3 initialPosition;
    public Vector3 targetPosition;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = tragrt.position;
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

    private void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "galade")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "galade")
        {
            Destroy(gameObject);
        }
    }
}