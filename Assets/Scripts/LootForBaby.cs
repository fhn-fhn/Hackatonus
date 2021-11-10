using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootForBaby : MonoBehaviour
{
    [SerializeField] List<GameObject> badPref, goodPrefs;
    [SerializeField] Transform positive, negative;
    [SerializeField] AudioClip _useClip;
    void Start()
    {
        Instantiate(badPref[Random.Range(0, badPref.Count)], negative);
        Instantiate(goodPrefs[Random.Range(0, goodPrefs.Count)], positive);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("baby"))
        {
            other.GetComponent<UIBabyController>().CollectObject(1);
            AudioSource.PlayClipAtPoint(_useClip, transform.position);
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("baby"))
        {
            collision.gameObject.GetComponent<UIBabyController>().CollectObject(1);
            AudioSource.PlayClipAtPoint(_useClip, transform.position);
            Destroy(gameObject);
        }
    }

}
