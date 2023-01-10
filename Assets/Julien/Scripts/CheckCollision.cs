using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cunegonde 
{ 

public class CheckCollision : MonoBehaviour
{
    //************************************ INITIATION DES VARIABLES ************************************

    public bool EnContact;


    //************************************ VERIFICATION DES COLLISIONS TANT QUE UNE ENTITE EST EN COLLISION ************************************
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collision detecte");
        EnContact = true;
    }

    //************************************ VERIFICATION SI LES DEUX ENTITES NE SONT PLUS EN COLLISION ************************************
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Je sors");
        EnContact = false;

    }


    // Start is called before the first frame update
    void Start()
    {

    }

    //************************************ SI LA COLLISION EST VRAIE, C'EST PERDU ************************************
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
