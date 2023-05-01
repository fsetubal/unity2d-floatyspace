using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchManager : MonoBehaviour
{
    private bool matchStarted;

    private void Awake()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (matchStarted) return;

        if(Input.GetMouseButtonDown(0))
        {
            matchStarted = true;
            Time.timeScale = 1;
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}