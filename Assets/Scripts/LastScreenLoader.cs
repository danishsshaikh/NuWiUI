using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScreenLoader : MonoBehaviour
{
    public void LastScreen()
    {
        //SceneManager.LoadScene(MainUIScreen);
        int currentSceneIndex = 2 ;
        SceneManager.LoadScene(currentSceneIndex - 2);
    }
}
