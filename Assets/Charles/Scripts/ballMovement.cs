using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody rb;
    


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = rb.velocity + new Vector3(1f,0f,0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = rb.velocity + new Vector3(-1f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = rb.velocity + new Vector3(0f, 0f, 1f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = rb.velocity + new Vector3(0f, 0f, -1f);
            }
        }

    }
}
