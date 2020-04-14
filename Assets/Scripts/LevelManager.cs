using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    Button[] LevelButton;
    
    public void Awake()
    {
        //PlayerPrefs.DeleteAll();
        int LevelReached = PlayerPrefs.GetInt("LevelReached", 1);

        LevelButton = new Button[transform.childCount];

        for (int i = 0; i < LevelButton.Length; i++)
        {
            LevelButton[i] = transform.GetChild(i).GetComponent<Button>();
            LevelButton[i].GetComponentInChildren<Text>().text = (i + 1).ToString();

            if(i + 1 > LevelReached)
            {
                LevelButton[i].interactable = false;
            }
        }
    }

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
