using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSwitch : MonoBehaviour
{
    public Boite boite;

    public Material Material1;
    public Material Material2;
    public GameObject Object;

    public Text colorChose;

    public int colorTest;
    public bool checkCouleur2;

    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
        checkCouleur2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Object.GetComponent<MeshRenderer>().material = Material2;
            
            checkCouleur2 = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
            
            checkCouleur2 = true;
        }

        

        

        colorChose.text = colorTest.ToString();

    }
}