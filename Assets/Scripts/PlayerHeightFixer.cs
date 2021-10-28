using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeightFixer : MonoBehaviour
{
    CharacterController _charController;
    [SerializeField] Camera _centerCam;
    [SerializeField] GameObject _mommy, FootR, FootL;



    void Start()
    {
        _charController = GetComponent<CharacterController>();
        Invoke(nameof(DelayCallibration), 1f);
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _charController.height = _centerCam.transform.localPosition.y;
        _mommy.transform.localPosition = new Vector3(_mommy.transform.localPosition.x, _charController.height, _mommy.transform.localPosition.z);


        FootL.transform.localPosition = new Vector3(FootL.transform.localPosition.x, -_charController.height * 0.5f, FootL.transform.localPosition.z);
        FootR.transform.localPosition = new Vector3(FootR.transform.localPosition.x, -_charController.height * 0.5f, FootR.transform.localPosition.z);
    }

    void DelayCallibration()
    {
        _mommy.transform.localScale *= _centerCam.transform.localPosition.y - 0.3f;
    }
}
