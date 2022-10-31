using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArrow : MonoBehaviour
{
    public SpriteRenderer sr;
    private GameObject following;
    // Start is called before the first frame update
    void Start()
    {
        following = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(following.transform.position.x, transform.position.y, following.transform.position.z);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
        }
    }
}
