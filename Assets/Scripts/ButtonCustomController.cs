using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonCustomController : MonoBehaviour
{
    [SerializeField] ButtonType type;
    [SerializeField] string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        switch(type)
        {
            case ButtonType.Exit:
                Application.Quit();
                break;
            case ButtonType.StartGame:
                SceneManager.LoadSceneAsync(sceneName);
                break;
        }
    }


}

public enum ButtonType
{
    Exit, StartGame
}
