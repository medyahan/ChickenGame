using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Failed : MonoBehaviour
{
    [SerializeField] private Button retryButton;
    [SerializeField] private Button menuButton;

    private int levelNo;

    private void Start()
    {
        retryButton.onClick.AddListener(Retry);
        menuButton.onClick.AddListener(Menu);
    }

    public void Retry()
    {
        Time.timeScale = 1f;

        levelNo = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene(levelNo);
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Play");
    }
}