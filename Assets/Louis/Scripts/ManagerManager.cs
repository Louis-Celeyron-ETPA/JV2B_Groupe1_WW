using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class ManagerManager : MonoBehaviour
{
    [Header("Manager")]
    public Difficulty dificultyManager;
    public MySceneManager sceneManager;
    public TimeManager timeManager;
    public GlobalGameManager globalGameManager;
    public LifeManager lifeManager;

    private static ManagerManager instance;
    public static ManagerManager Instance
    {
        get
        {
            if(instance == null)
            {
                var newManager = new GameObject();
                var m = newManager.AddComponent<ManagerManager>();
                m.dificultyManager = newManager.AddComponent<Difficulty>();
                m.sceneManager = newManager.AddComponent<MySceneManager>();
                m.timeManager = newManager.AddComponent<TimeManager>();
                m.globalGameManager = newManager.AddComponent<GlobalGameManager>();
                m.lifeManager = newManager.AddComponent<LifeManager>();
                Debug.LogError("Aucune instance trouvée, une instance temporaire à été crée, pour une experience optimal lancer depuis le main menu. Bisous, Louis");
                return m;
            }
            else
            {
                return instance;
            }
        }
        set
        {
            instance = value;
        }
    }
    public static Difficulty DifficultyManager => Instance.dificultyManager;
    public static MySceneManager SceneManager => Instance.sceneManager;
    public static TimeManager TimeManager=> Instance.timeManager;
    public static GlobalGameManager GlobalGameManager=> Instance.globalGameManager;
    public static LifeManager LifeManager=> Instance.lifeManager;



    private void Awake()
    {
        if(ManagerManager.instance != null)
        {
            return;
        }
        else
        {
            ManagerManager.instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
    
}
