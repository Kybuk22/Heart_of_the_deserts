using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuscriptUI : MonoBehaviour
{
    public void NewGame ()
    {
        SceneManager.LoadScene("Map");
    }
    public void Load ()
    {
        SceneManager.LoadScene("Map");
    }
    public void Settings ()
    {
        SceneManager.LoadScene("Map");
    }

    public void QuitButton ()
    {
        Application.Quit();
    }
}
