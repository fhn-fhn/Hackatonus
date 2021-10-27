using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] float SecondsForMatch;
    [SerializeField] TextMeshProUGUI TimerUI;
    private bool gameOver;
    void Start()
    {
        int minutes = Mathf.FloorToInt(SecondsForMatch / 60);
        int seconds = Mathf.FloorToInt(SecondsForMatch % 60);
        TimerUI.text = (minutes <= 9 ? "0" : System.String.Empty) + minutes
            + ":" + (seconds <= 9 ? "0" : System.String.Empty) + seconds;
        StartCoroutine(nameof(UpdateTimer));
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
