using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private int level;

    void Start()
    {
        playButton.onClick.AddListener(PlayGame);

        Debug.Log(PlayerPrefs.GetInt("level"));
        if (PlayerPrefs.GetInt("level") == 5)
            PlayerPrefs.SetInt("level", 0);
        Debug.Log(PlayerPrefs.GetInt("level"));
    }

    public void PlayGame()
    {
        
        level = PlayerPrefs.GetInt("level");

        SceneManager.LoadScene(level);

    }
}
