using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSwitch : MonoBehaviour
{

    public Material Material1;
    public Material Material2;
    public GameObject Object;

    public Text colorChose;

    public int colorTest;

    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Object.GetComponent<MeshRenderer>().material = Material2;
            colorTest += 1;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
            colorTest -= 1;
        }

        colorChose.text = colorTest.ToString();
    }
}