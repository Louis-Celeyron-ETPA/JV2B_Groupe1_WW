using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public  Dropdown dropdown;
    private int currentIndex;
    private List<string> allScenes;

    void Start()
    {
        if(!dropdown)
        {
            return;
        }

        allScenes = dropdown.options.Select(o => o.text).ToList();
    }
    public void SetCurrentIndex(int newIndex)
    {
        currentIndex = newIndex;
    }
    public void LoadSceneAtCurrentIndex()
    {
        SceneManager.LoadScene(dropdown.options[currentIndex].text);
    }

    public void LoadRandomScene()
    {
        var nextScene =  SceneManager.GetActiveScene().name;
        while(nextScene ==  SceneManager.GetActiveScene().name)
        {
            nextScene = allScenes[Random.Range(0, allScenes.Count)];
        }

        SceneManager.LoadScene(nextScene);
    }
    
}
