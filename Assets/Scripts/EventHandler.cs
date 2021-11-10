using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EventHandler : MonoBehaviour
{
    [SerializeField] GameObject BabyGameOverPanel, PlayerGameOverPanel;
    [SerializeField] TextMeshProUGUI BabyCount, PlayerCount, BabyInfo, PlayerInfo;
    [SerializeField] string sceneName;
    int countDown = 6;
    AsyncOperation async;
    void Start()
    {
        Time.timeScale = 1;
        UIBabyController.BabyWin += BabyWin;
        LevelTimer.PlayerWin += PlayerWin;
        UIBabyController.Pause += SetPause;
    }

    private void OnDisable()
    {
        UIBabyController.BabyWin -= BabyWin;
        LevelTimer.PlayerWin -= PlayerWin;
        UIBabyController.Pause -= SetPause;
    }

    void BabyWin()
    {
        
        BabyGameOverPanel.SetActive(true);
        PlayerGameOverPanel.SetActive(true);

        Transform temp = FindObjectOfType<OVRPlayerController>().transform;
        PlayerGameOverPanel.transform.position = temp.position + (temp.forward * 3) + temp.up;
        PlayerGameOverPanel.transform.localRotation = FindObjectOfType<OVRPlayerController>().transform.rotation;


        BabyInfo.text = "Подзравляю с победой, а сможешь еще раз?";
        PlayerInfo.text = "Вы проиграли, но реванш скоро начнется";
        StartCoroutine(nameof(Countdown));


    }
    void PlayerWin()
    {
        BabyGameOverPanel.SetActive(true);
        PlayerGameOverPanel.SetActive(true);
        Transform temp = FindObjectOfType<OVRPlayerController>().transform;
        PlayerGameOverPanel.transform.position = temp.position + (temp.forward * 3) + temp.up;
        PlayerGameOverPanel.transform.localRotation = FindObjectOfType<OVRPlayerController>().transform.rotation;
       
        BabyInfo.text = "Вы проиграли, но реванш скоро начнется";
        PlayerInfo.text = "Подзравляю с победой, а сможешь еще раз?";
        StartCoroutine(nameof(Countdown));
    }

    IEnumerator Countdown()
    {
        Time.timeScale = 0;
        async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;
        while (countDown >= 0)
        {
            SetCounts(countDown);
            yield return new WaitForSecondsRealtime(1);
            countDown--;
        }

        async.allowSceneActivation = true;

    }

    void SetCounts(int count)
    {
        BabyCount.text = count.ToString();
        PlayerCount.text = count.ToString();
    }

    public void SetPause()
    {
        if(Time.timeScale == 0)
        {
            StartCoroutine(nameof(UnPause));
        }
        else
        {
            StartCoroutine(nameof(Pause));
        }
    }
    IEnumerator Pause()
    {
        BabyGameOverPanel.SetActive(true);
        PlayerGameOverPanel.SetActive(true);
        Transform temp = FindObjectOfType<OVRPlayerController>().transform;
        PlayerGameOverPanel.transform.position = temp.position + (temp.forward * 3) + temp.up;
        PlayerGameOverPanel.transform.localRotation = FindObjectOfType<OVRPlayerController>().transform.rotation;
        BabyInfo.text = "Пауза";
        PlayerInfo.text = "Пауза";
        int timeDown = 3;
        while (timeDown >= 0)
        {
            SetPasueText(timeDown);
            yield return new WaitForSecondsRealtime(1);
            timeDown--;
        }
        Time.timeScale = 0;
    }

    IEnumerator UnPause()
    {
       
        Transform temp = FindObjectOfType<OVRPlayerController>().transform;
        PlayerGameOverPanel.transform.position = temp.position + (temp.forward * 3) + temp.up;
        PlayerGameOverPanel.transform.localRotation = FindObjectOfType<OVRPlayerController>().transform.rotation;
        BabyInfo.text = "Игра начнется";
        PlayerInfo.text = "Игра начнется";
        int timeDown = 3;
        while (timeDown >= 0)
        {
            SetPasueText(timeDown);
            yield return new WaitForSecondsRealtime(1);
            timeDown--;
        }
        Time.timeScale = 1;
        BabyGameOverPanel.SetActive(false);
        PlayerGameOverPanel.SetActive(false);
    }

    void SetPasueText(int count)
    {
        BabyCount.text = "через "+count.ToString();
        PlayerCount.text = "через "+count.ToString();
    }
}
