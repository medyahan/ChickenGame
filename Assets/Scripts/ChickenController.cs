using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenController : MonoBehaviour
{
    public int totalScore;

    [SerializeField] private int score = 50;

    [SerializeField] private GameObject timeBar;
    TimeBarScript timeBarScript;

    Animation [] anims;
    public static bool collisionWithMud = false;

    public int timeScore;

    [SerializeField] private Text timeScoreText;
    public GameObject timeScoreObj;

    private void Start()
    {
        timeBarScript = timeBar.GetComponent<TimeBarScript>();
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "score")
        {
            AddScore(score);
            
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "coop")
        {
            GameManager.instance.trueIcon.SetActive(true);
            timeBarScript.enabled = false;

            GetTimeScore();
            timeScoreText.text = "+ " + timeScore;
            timeScoreObj.SetActive(true);
            AddScore(timeScore);

            GameManager.instance.Invoke("Won", 1.5f);
            gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "mud")
        {
            collisionWithMud = true;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "mud")
        {
            collisionWithMud = false;
        }
    }

    public void AddScore(int score)
    {
        totalScore += score;
    }

    public void GetTimeScore()
    {
        float rate = timeBarScript.timeLeft / timeBarScript.maxTime;


        if (rate < 0.25f)
        {
            timeScore = 100;
        }
        else if (rate >= 0.25f && rate < 0.5f)
        {
            timeScore = 200;
        }
        else if (rate >= 0.5f && rate < 0.75f)
        {
            timeScore = 300;
        }
        else
        {
            timeScore = 400;
        }
    }
}
