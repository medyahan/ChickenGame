using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarScript : MonoBehaviour
{
    Image timeBar;
    private float maxTime;
    private float timeLeft;
    [SerializeField] private GameObject timesUpText;

    void Start()
    {
        timesUpText.SetActive(false);
        timeBar = GetComponent<Image>();

        maxTime = LevelManager.instance.levelTime;
        timeLeft = maxTime;
    }

    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            GameManager.isGameEnded = true;
            timeLeft = 0;
            GameManager.instance.Invoke("Failed", 1.5f);
        }
    }
}
