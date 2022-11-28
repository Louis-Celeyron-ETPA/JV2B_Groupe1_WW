using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightMove()
    {
        rb.velocity += new Vector3(0.01f, 0f, 0f);
    }
    public void LeftMove()
    {
        rb.velocity += new Vector3(-0.01f, 0f, 0f);
    }
    public void FrontMove()
    {
        rb.velocity += new Vector3(0f, 0f, 0.01f);
    }
    public void BackMove() 
    {
        rb.velocity += new Vector3(0f, 0f, -0.01f);
    }
}
