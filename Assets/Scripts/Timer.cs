using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float gameDurationInSeconds = 2;
    private float timeRemaining;
    public bool timerIsRunning = false;



    private void Start()
    {
        timeRemaining = gameDurationInSeconds;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("MainScene");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    public string GetTimeForDisplay()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }



}
