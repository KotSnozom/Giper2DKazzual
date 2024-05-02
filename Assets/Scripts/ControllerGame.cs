using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerGame : MonoBehaviour
{
    public UnityAction OnStart;
    [SerializeField] SpawnEnemy spawnEnemy;
    public static bool isPause = true;
    private void Start()
    {
        OnStart += spawnEnemy.GenerateSpawnEnemy;
        Debug.Log(isPause);
    }

    public void GameMode()
    {
        isPause = !isPause;
        switch (isPause)
        {
            case true:
                Time.timeScale = 0;
                break;
            case false:
                Time.timeScale = 1;
                OnStart.Invoke();
                break;
        }
    }
}
