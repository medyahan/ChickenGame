using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Won : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private Button menuButton;

    [SerializeField] private Text levelText;
    [SerializeField] private Text totalText;
    [SerializeField] private Text scoreText;

    private int level;
    private int next;

    private int total;
    private int score;

    private bool isActive = false;

    Coroutine coroutine;

    private void Start()
    {
        //nextButton.onClick.AddListener(NextLevel);
        //menuButton.onClick.AddListener(Menu);
        Debug.Log(PlayerPrefs.GetInt("level"));

        level = PlayerPrefs.GetInt("level");
        score = GameManager.instance.score;
        total = PlayerPrefs.GetInt("totalscore");

        levelText.text = "level " + (level + 1);
        totalText.text = "" + total;
        scoreText.text = "+ " + score;
    }

    private void FixedUpdate()
    {
        

        if(!isActive)
        {
            StartCoroutine(AddTotalScore());
        }
        else
        {
            //StopCoroutine(coroutine);
            nextButton.onClick.AddListener(NextLevel);
            menuButton.onClick.AddListener(Menu);
        }
        
    }

    private IEnumerator AddTotalScore()
    {

        yield return new WaitForSeconds(1f);

        while (score != 0)
        {
            total = PlayerPrefs.GetInt("totalscore");
            PlayerPrefs.SetInt("totalscore", total + 1);
            totalText.text = "" + total;
            score--;
            scoreText.text = "+ " + score;


            Debug.Log(total);
            Debug.Log(score);

            if (score <= 0)
            {
                isActive = true;
                PlayerPrefs.SetInt("totalscore", total + 1);
                totalText.text = "" + total;
                StopCoroutine(AddTotalScore());
               
            }

            yield return new WaitForSeconds(.1f); ;
        }   

    }
    public void NextLevel()
    {

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
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Play");
    }
}