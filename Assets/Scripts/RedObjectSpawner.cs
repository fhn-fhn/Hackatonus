using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject RedObj;
    void Start()
    {
        foreach(var point in GetComponentsInChildren<Transform>())
        {
            Instantiate(RedObj, point);
        }
    }


}
