using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSwitcher : MonoBehaviour
{
    TextMeshProUGUI _textMesh;
    [SerializeField] float _timer;
    [SerializeField] List<string> _messages;

    int index = 0;
    [SerializeField] bool dontSwapText;
    void Start()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
        StartCoroutine(nameof(SwapText));

    }

    IEnumerator SwapText()
    {
        while(!dontSwapText)
        {
            _textMesh.text = _messages[index];
            yield return new WaitForSeconds(_timer);
            index++;

            if (index >= _messages.Count)
                index = 0;

        }
    }
 
}
