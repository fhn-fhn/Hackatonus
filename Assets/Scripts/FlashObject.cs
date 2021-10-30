using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashObject : MonoBehaviour
{
    [SerializeField] GameObject childrenGameObj;


    public void SetDebuffFlash(float timer)
    {
        childrenGameObj.SetActive(true);
        Invoke(nameof(ResetDebuff), timer);
    }
    public void ResetDebuff()
    {
        childrenGameObj.SetActive(false);
    }
}
