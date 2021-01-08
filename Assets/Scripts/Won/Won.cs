using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Won : MonoBehaviour
{
    [SerializeField] private Button nextButton;

    private int level;
    private int next;

    private void Start()
    {
        nextButton.onClick.AddListener(NextLevel);
        Debug.Log(PlayerPrefs.GetInt("level"));
    }

    public void NextLevel()
    {
        level = PlayerPrefs.GetInt("level");

        if(level == 4)
        {
            PlayerPrefs.SetInt("level", 0);
            SceneManager.LoadScene("Play");
        }
        else
        {
            level = level + 1;
            PlayerPrefs.SetInt("level", level);
            next = PlayerPrefs.GetInt("level");
            SceneManager.LoadScene(next);
        }
        
    }   


}