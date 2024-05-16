using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{   
    private string currentText;
    private string currentSceneName;

    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name; // Set the current scene name at start
    }

    public void LoadNextScene(string switchSceneText) 
    {

        currentText = switchSceneText.ToLower();
        Debug.Log(currentText);

        switch (currentSceneName)
        {
            case "Main": 
                if (currentText == "options")
                    SceneManager.LoadScene("Options");
                else if (switchSceneText == "start")
                    SceneManager.LoadScene("MinuckSampleScene3");
                break;
            case "Options": 
                if (currentText == "main")
                    SceneManager.LoadScene("Main");
                break;
            case "MinuckSampleScene3": 
                if (currentText == "main")
                    SceneManager.LoadScene("Main");
                break;
            default:
                break;
        }
    }

}