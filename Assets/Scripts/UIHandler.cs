using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene("AR Agriculture");
    }

    public void QuitApp()
    {
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
