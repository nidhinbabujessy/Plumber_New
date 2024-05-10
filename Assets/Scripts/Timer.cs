using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float timeRemaining = 120f; 
    private bool timerIsRunning = false;

    public GameObject timer;
    public GameObject FailWindow;
    void Start()
    {
        
        timerIsRunning = true;

        timer.SetActive(true);
        FailWindow.SetActive(false);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                Debug.Log("Timer expired!");
                timer.SetActive(false);
                FailWindow.SetActive(true);
                
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

       
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
