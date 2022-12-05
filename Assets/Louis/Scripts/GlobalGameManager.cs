using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameManager : MonoBehaviour
{
    public int MinigamesFinished;
    
    public void WinGame()
    {
        Debug.Log("C'est perdu");
    }

    public void LoseGame()
    {
        Debug.Log("C'est gagné");
    }
    public void EndOfMinigame(MinigameRating mgRating)
    {
        switch (mgRating)
        {
            case MinigameRating.Fail:
                break;
            default:
                ManagerManager.GlobalGameManager.MinigamesFinished++;
                break;
        }

        if (Consequence(mgRating))
        {
            ManagerManager.SceneManager.LoadRandomScene();   
        }
        else
        {
            LoseGame();
        }
    }

    public bool Consequence(MinigameRating mgRating)
    {
        return ManagerManager.TimeManager.Consequence(mgRating); 
        return ManagerManager.LifeManager.Consequence(mgRating); 
    }
}
