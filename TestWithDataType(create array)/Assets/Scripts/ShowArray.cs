using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowArray : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void Text_update()
    {
        text.text = FindObjectOfType<Data>().Array[0].ToString();
    }
}
