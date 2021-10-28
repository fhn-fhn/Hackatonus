using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomMovements : MonoBehaviour
{
    OVRPlayerController _ovrPlayer;
    CharacterController _charController;

    float defaultSpeed, defaultHeight;
    bool init = false;
    void Start()
    {
        _ovrPlayer = GetComponent<OVRPlayerController>();
        _charController = GetComponent<CharacterController>();
        Invoke(nameof(DelayDefaultSet), 1);
    }

    void DelayDefaultSet()
    {
        defaultSpeed = _ovrPlayer.Acceleration;
        defaultHeight = _charController.height;
        init = true;
    }
    
    void FixedUpdate()
    {
        if(init)
        if(_charController.height < defaultHeight * 0.7f)
        {
            _ovrPlayer.Acceleration = defaultSpeed * 0.5f;
        }
        else
        {
            _ovrPlayer.Acceleration = defaultSpeed;
        }
    }
}
