using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    //paramaters
    int currentScore = 0;
    [SerializeField]
    TextMeshProUGUI yourScoreDisplay;
    int scoreBlockDestroy=1;
    [SerializeField]
    TextMeshProUGUI scoreText;

    
    public void Awake()
    {
        int CountBlocks = FindObjectsOfType<Score>().Length;
        if(CountBlocks>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
 
        }
    }

    public void Start()
    {
        yourScoreDisplay.text = "Your Score:";
        scoreText.text = currentScore.ToString();
    }
    public void Update()
    {
        
    }

    public void AddScore()
    {
        currentScore += scoreBlockDestroy;
        scoreText.text = currentScore.ToString();
        if(currentScore>HighScore.highScore)
        {
            HighScore.highScore = currentScore;
        }

    }

    public void GameReset()
    {
        Destroy(gameObject);
    
    }

}
