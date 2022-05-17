using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshPro timerText;
    private Timer timer;



    void Start()
    {
        timer = GetComponent<Timer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();
             
        }
    }
}
