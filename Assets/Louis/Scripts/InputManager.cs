using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public InputStruct4 directions;
    public InputStruct2 pointsMorts;
    public InputStruct3  action;
    private float deadZone = 0.8f;
    private bool isPointMortH = true, isPointMortV = true;
    private void Update()
    {
        if(Input.GetAxis("Horizontal") < deadZone && Input.GetAxis("Horizontal") > -deadZone)
        {
            if(!isPointMortH)
            {
                pointsMorts.horizontal.Invoke();
                isPointMortH = true;
            }
        }
        if (Input.GetAxis("Horizontal")>= deadZone)
        {
            directions.right.Invoke();
            isPointMortH = false;
        }
        if (Input.GetAxis("Horizontal") <= -deadZone)
        {
            directions.left.Invoke();
            isPointMortH = false;
        }

        if (Input.GetAxis("Vertical") < deadZone && Input.GetAxis("Vertical") > -deadZone)
        {
            if (!isPointMortV)
            {
                pointsMorts.vertical.Invoke();
                isPointMortV = true;
            }
        }
        if (Input.GetAxis("Vertical")>= deadZone)
        {
            directions.up.Invoke();
            isPointMortV = false;

        }
        if (Input.GetAxis("Vertical") <= -deadZone)
        {
            directions.down.Invoke();
            isPointMortV = false;
        }

        if (Input.GetAxis("Fire1")>= deadZone)
        {
            action.onStayed.Invoke();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            action.onPressed.Invoke();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            action.onUp.Invoke();
        }


    }

    public void DebugLog(string input)
    {
        Debug.Log(input);
    }

}

[System.Serializable]
public struct InputStruct3
{
    public UnityEvent onPressed, onUp, onStayed;
}
[System.Serializable]
public struct InputStruct4
{
    public UnityEvent left,right,down,up;
}
[System.Serializable]
public struct InputStruct2
{
    public UnityEvent horizontal, vertical;
}
