using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // UI
    public TextMeshProUGUI tempsText;

    float timer = 1f;
    float maxTimer = 1f;
    int showedTimer = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            showedTimer --;
            timer = maxTimer;
            tempsText.text = showedTimer.ToString();
        }

        if (showedTimer == 0)
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }
    }
}
