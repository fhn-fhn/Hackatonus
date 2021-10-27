using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForSpec : MonoBehaviour
{
   
    void Start()
    {
        Invoke(nameof(Delay), 2f);
    }

    void Delay()
    {
        GetComponent<Camera>().depth = 1;
    }

}
