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
    }

    private void OnDisable()
    {
        UIBabyController.BabyWin -= BabyWin;
        LevelTimer.PlayerWin -= PlayerWin;
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

}
