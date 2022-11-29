using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public int maxDifficulty = 9;
    public int minDifficulty = 0;

    private int currentDifficulty = 1;
    public void RiseDifficulty()
    {
        currentDifficulty++;
        currentDifficulty = Mathf.Clamp(currentDifficulty, minDifficulty, maxDifficulty);
    }
    public void DowngradeDifficulty()
    {
        currentDifficulty--;
        currentDifficulty = Mathf.Clamp(currentDifficulty, minDifficulty, maxDifficulty);
    }
    public int GetDifficulty()
    {
        return currentDifficulty;
    }
}
