using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int myScene;
    public void LoadMyScene() 
    {
        SceneManager.LoadScene(myScene);
    }
}
