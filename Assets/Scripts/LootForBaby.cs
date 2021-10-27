using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootForBaby : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("baby"))
        {
            other.GetComponent<UIBabyController>().CollectObject(1);
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("baby"))
        {
            collision.gameObject.GetComponent<UIBabyController>().CollectObject(1);
            Destroy(gameObject);
        }
    }

}
