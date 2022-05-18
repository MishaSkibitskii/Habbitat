using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        Destroy(GameObject.Find("Main Camera"));
        Destroy(GameObject.Find("main"));
        Destroy(GameObject.Find("Back"));

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Additive);
    }
}
