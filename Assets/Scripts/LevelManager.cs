using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private int levelNo;
    public int levelTime;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        // LEVEL BİLGİLERİ //

        levelNo = SceneManager.GetActiveScene().buildIndex + 1;

        switch (levelNo)
        {
            case 1:
                {
                    levelTime = 20;
 
                    break;
                }
            case 2:
                {
                    levelTime = 20;

                    break;
                }
            case 3:
                {
                    levelTime = 20;

                    break;
                }
            case 4:
                {
                    levelTime = 20;

                    break;
                }
            case 5:
                {
                    levelTime = 20;

                    break;
                }
        }
    }
}
