using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIBabyController : MonoBehaviour
{
    [SerializeField] int objCount;
    [SerializeField] TextMeshProUGUI textMesh;
    public void CollectObject(int count)
    {
        objCount -= count;
        textMesh.text = objCount.ToString();
        if(objCount <= 0)
        {
            Debug.Log("WinningBaby");
        }

    }

    private void Start()
    {
        textMesh.text = objCount.ToString();
    }
}
