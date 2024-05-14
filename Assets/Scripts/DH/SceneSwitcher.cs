using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{   
    public inputHandling inputHandler;
    private string currentText;
    private string currentSceneName;

    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name; // Set the current scene name at start
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (inputHandler.getText() != null)
            {
                currentText = inputHandler.getText().ToLower();
            }

            if (!string.IsNullOrEmpty(currentText))
            {
                LoadNextScene(currentText);
                currentText = "";
            }
        }
    }

    void LoadNextScene(string switchSceneText) 
    {
        switch (currentSceneName)
        {
            case "Main": 
                if (switchSceneText == "options")
                    SceneManager.LoadScene("Options");
                else if (switchSceneText == "start")
                    SceneManager.LoadScene("Select_chr");
                break;
            case "Options": 
                if (switchSceneText == "main")
                    SceneManager.LoadScene("Main");
                break;
            case "Select_chr": 
                if (switchSceneText == "main")
                    SceneManager.LoadScene("Main");
                break;
            default:
                break;
        }
    }

}