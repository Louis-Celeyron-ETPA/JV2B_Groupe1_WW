using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public InputStruct right, left, up, down, action;
    private float deadZone = 0.8f;

    private void Update()
    {
        if(Input.GetAxis("Horizontal")>= deadZone)
        {
            right.onStayed.Invoke();
        }
        if (Input.GetAxis("Horizontal") <= -deadZone)
        {
            left.onStayed.Invoke();
        }
        if(Input.GetAxis("Vertical")>= deadZone)
        {
            up.onStayed.Invoke();
        }
        if (Input.GetAxis("Vertical") <= -deadZone)
        {
            down.onStayed.Invoke();
        }
        if(Input.GetAxis("Fire1")>= deadZone)
        {
            action.onStayed.Invoke();
        }

        if(Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                right.onPressed.Invoke();
            }
            if(Input.GetAxisRaw("Horizontal")<0)
            {
                left.onPressed.Invoke();
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                up.onPressed.Invoke();
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                down.onPressed.Invoke();
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            action.onPressed.Invoke();
        }


    }

    public void DebugLog(string input)
    {
        Debug.Log(input);
    }

}

public struct InputStruct
{
    public UnityEvent onPressed, onUp, onStayed;
}
