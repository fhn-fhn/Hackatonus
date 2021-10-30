using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIBabyController : MonoBehaviour
{
    [SerializeField] int objCount;
    [SerializeField] TextMeshProUGUI textMeshCount, textTimer;

    LevelTimer _levelTimer;
    public static event Action<string> CountHandler;
    public static event Action BabyWin;
    public void CollectObject(int count)
    {
        objCount -= count;
        textMeshCount.text = objCount.ToString();
        CountHandler?.Invoke(textMeshCount.text);
        if (objCount <= 0)
        {
            Debug.Log("WinningBaby");
            BabyWin?.Invoke();
        }

    }

    private void Start()
    {
        textMeshCount.text = objCount.ToString();
        _levelTimer = FindObjectOfType<LevelTimer>();
        _levelTimer.iTimer += TimeLeftUpdate;
        CountHandler?.Invoke(textMeshCount.text);

    }

    private void OnDisable()
    {
        _levelTimer.iTimer -= TimeLeftUpdate;
    }


    void TimeLeftUpdate(string s)
    {
        textTimer.text = s;
    }
}
