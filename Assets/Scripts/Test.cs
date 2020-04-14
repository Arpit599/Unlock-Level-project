using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    int CurrentLevel;
   
    public void LoadLevel()
    {
        CurrentLevel = PlayerPrefs.GetInt("LevelReached", 1);
        
        //Debug.Log("Current level="+CurrentLevel);
        if(CurrentLevel == SceneManager.GetActiveScene().buildIndex)
        {
            PlayerPrefs.SetInt("LevelReached", CurrentLevel + 1);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
