using TMPro;
using UnityEngine;

public class ShowArray : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "";
    }
    public void Text_update()
    {
        text.text = "";
        for (int i = 0; i < FindObjectOfType<Data>().Array.Length; i++)
        {
            text.text += FindObjectOfType<Data>().Array[i].ToString()+" ";
        }
    }
}
