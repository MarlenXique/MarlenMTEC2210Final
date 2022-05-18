using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Awake()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }



    void Start()
    {
        score = GetComponent<Text>();
       
    }

    
    void Update()
    {

        score.text = "Score: " + scoreValue;


    }


}
