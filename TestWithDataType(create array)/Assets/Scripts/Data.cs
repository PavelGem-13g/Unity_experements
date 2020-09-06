using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // Start is called before the first frame update
    int[] array;

    void Awake()
    {
        if (FindObjectsOfType<Data>().Length>1) 
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public int[] Array 
    {
        get 
        {
            return array;
        }
    }

    private void Start()
    {
        array = new int[] {1,23,2};
    }
}
