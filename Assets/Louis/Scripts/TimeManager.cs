using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float globalTime;
    public float startTimer=300;

    [SerializeField]
    private float perfectTimeAdded = 30, normalTimeAdded=15, failTimeAdded=-15;
    public bool debugTimer = true;

    public GUIStyle style;

    private void Start()
    {
        style.normal.textColor = Color.blue;
        globalTime = startTimer;
    }

    private void Update()
    {
        globalTime -= Time.deltaTime;
      
    }

    private void OnGUI()
    {
        if(debugTimer)
        {
            GUILayout.Label(globalTime.ToString("00"),style);
        }
    }

    public bool Consequence(MinigameRating mgRating)
    {
        var tempAddToTime = 0f;
        switch (mgRating)
        {
            case MinigameRating.Fail:
                tempAddToTime = ManagerManager.TimeManager.failTimeAdded;
                break;
            case MinigameRating.Success:
                tempAddToTime = ManagerManager.TimeManager.normalTimeAdded;
                break;
            case MinigameRating.Perfect:
                tempAddToTime = ManagerManager.TimeManager.perfectTimeAdded;
                break;
            default:
                tempAddToTime = 0;
                break;
        }
        globalTime += tempAddToTime;
        if(globalTime <=0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
