using UnityEngine;

public class Data : MonoBehaviour
{
    int[] array;
    public int[] Array
    {
        get
        {
            return array;
        }
    }

    void Awake()
    {
        //Check that Data not regenerated
        gameObject.name = gameObject.name + " " + PlayerPrefs.GetInt("number");
        PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number") + 1);

        //Delete copies of Data and make original static
        if (FindObjectsOfType<Data>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }


    private void Start()
    {
        array = new int[] { 1, 23, 2, PlayerPrefs.GetInt("number") };
    }
}
