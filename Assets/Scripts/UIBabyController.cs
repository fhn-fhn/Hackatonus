using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIBabyController : MonoBehaviour
{
    [SerializeField] int objCount;
    [SerializeField] TextMeshProUGUI textMeshCount, textTimer;

    LevelTimer _levelTimer;
    public void CollectObject(int count)
    {
        objCount -= count;
        textMeshCount.text = objCount.ToString();
        if(objCount <= 0)
        {
            Debug.Log("WinningBaby");
        }

    }

    private void Start()
    {
        textMeshCount.text = objCount.ToString();
        _levelTimer = FindObjectOfType<LevelTimer>();
        _levelTimer.iTimer += TimeLeftUpdate;

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
