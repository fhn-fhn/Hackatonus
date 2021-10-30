using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using System;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] float SecondsForMatch;
    [SerializeField] TextMeshProUGUI TimerUI;
    private bool gameOver;

    public event Action<string> iTimer;
    void Start()
    {
        int minutes = Mathf.FloorToInt(SecondsForMatch / 60);
        int seconds = Mathf.FloorToInt(SecondsForMatch % 60);
        TimerUI.text = (minutes <= 9 ? "0" : System.String.Empty) + minutes
            + ":" + (seconds <= 9 ? "0" : System.String.Empty) + seconds;
        StartCoroutine(nameof(UpdateTimer));
        iTimer?.Invoke(TimerUI.text);
    }

    IEnumerator UpdateTimer()
    {
        while (!gameOver)
        {

            SecondsForMatch -= Time.fixedDeltaTime;
           

            int minutes = Mathf.FloorToInt(SecondsForMatch / 60);
            int seconds = Mathf.FloorToInt(SecondsForMatch % 60);
            TimerUI.text = (minutes <= 9 ? "0" : System.String.Empty) + minutes
                + ":" + (seconds <= 9 ? "0" : System.String.Empty) + seconds;
            iTimer?.Invoke(TimerUI.text);
            if (SecondsForMatch <= Time.fixedDeltaTime && !gameOver)
            {
                EndGame();
            }

            yield return new WaitForFixedUpdate();
            
        }

    }

    public void SetGameOver()
    {
        gameOver = true;
    }

    void EndGame()
    {
        gameOver = true;
        Debug.Log("WinPlayer");
    }
}
