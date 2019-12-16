using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LastScreenLoader : MonoBehaviour
{
    //public GameObject MainUIScreen;
    public void LastScreen()
    {
        SceneManager.LoadScene("MainUIScreen");
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentSceneIndex - 1);
    }
}
