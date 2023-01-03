using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cunegonde 
{ 

public class CheckCollision : MonoBehaviour
{

    public bool EnContact;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collision detecte");
        EnContact = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Je sors");
        EnContact = false;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    if (EnContact == true)
    {
        Debug.Log("Vous avez perdu...");
    }
    }
}
}
