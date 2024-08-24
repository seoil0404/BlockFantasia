using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("CharacterChooseScene");
    }

    public void LoadSettingScene()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
