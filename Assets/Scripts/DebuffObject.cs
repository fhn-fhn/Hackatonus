using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffObject : MonoBehaviour
{
    [SerializeField] DebuffType debuffType;
    [SerializeField] float timer = 5;
    private FlashObject flashObj;
    private MomMovements momMovements;

    private void Start()
    {
        momMovements = FindObjectOfType<MomMovements>();
       

        if(Random.value <= 0.5f)
        {
            debuffType = DebuffType.Slower;
        }else
        {
            debuffType = DebuffType.Flash;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "baby")
        {
            switch(debuffType)
            {
                case DebuffType.Slower:
                    momMovements.SetDebuffMovement(timer);
                    Destroy(gameObject);
                    break;
                case DebuffType.Flash:
                    FindObjectOfType<FlashObject>().SetDebuffFlash(timer);
                    Destroy(gameObject);
                    break;
            }
            

        }
    }
}

public enum DebuffType
{
    Slower, Flash
}
