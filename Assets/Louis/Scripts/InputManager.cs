using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent onRight, onLeft, onUp, onDown, onAction;
    public UnityEvent onRightPressed, onLeftPressed, onUpPressed, onDownPresed, onActionPressed;

    private void Update()
    {
        if(Input.GetAxis("Horizontal")>=0.2)
        {
            onRight.Invoke();
        }
        if (Input.GetAxis("Horizontal") <= -0.2)
        {
            onLeft.Invoke();
        }
        if(Input.GetAxis("Vertical")>=0.2)
        {
            onUp.Invoke();
        }
        if (Input.GetAxis("Vertical") <= -0.2)
        {
            onDown.Invoke();
        }
        if(Input.GetAxis("Fire1")>=0.2)
        {
            onAction.Invoke();
        }

        if(Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                onRightPressed.Invoke();
            }
            if(Input.GetAxisRaw("Horizontal")<0)
            {
                onLeftPressed.Invoke();
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                onUpPressed.Invoke();
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                onDownPresed.Invoke();
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            onActionPressed.Invoke();
        }
    }

    public void DebugLog(string input)
    {
        Debug.Log(input);
    }

}
