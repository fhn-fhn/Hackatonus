using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BabyAudioController : MonoBehaviour
{
    AudioSource _aSource;
    [SerializeField] AudioClip stepClip, runClip;
    void Start()
    {
        _aSource = GetComponent<AudioSource>();
    }

    public void PlayStep()
    {
        _aSource.clip = stepClip;
        _aSource.Play();
    }

    public void PlayRun()
    {
        _aSource.clip = runClip;
        _aSource.Play();
    }




}
