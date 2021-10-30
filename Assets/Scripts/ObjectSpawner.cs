using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject objectForSpawn;
    void Start()
    {
        foreach(var point in GetComponentsInChildren<Transform>())
        {
            Instantiate(objectForSpawn, point);
        }
    }


}
