using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boule : MonoBehaviour
{
    public Rigidbody rb;
    public Canon canon;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(canon.rotationZ);
        transform.rotation = canon.transform.rotation;
        Debug.Log(transform.rotation.z);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized;
        transform.position += transform.up;

        
    }
}
