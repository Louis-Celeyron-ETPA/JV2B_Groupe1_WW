using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LifeManager : MonoBehaviour
{
    public int MaxLife;
    
    private int currentLife;

    private bool shouldTimeGoes;

    private void Start()
    {
        currentLife = MaxLife;
    }
    
    public int GetCurrentLife()
    {
        return currentLife;
    }

    private void RemoveLife()
    {
        SetCurrentLife(currentLife-1);
    }
    
    private void SetCurrentLife(in int newValue)
    {
        currentLife = Mathf.Clamp(newValue, 0, MaxLife);
        if (currentLife == 0)
        {
           ManagerManager.GlobalGameManager.LoseGame();
        }
    }

    public bool Consequence(MinigameRating mgRating)
    {
        switch (mgRating)
        {
            case MinigameRating.Fail:
                RemoveLife();
                break;
            default:
                break;
        }

        if (currentLife <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
