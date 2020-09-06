using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] array;

    void Awake()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
