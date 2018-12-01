using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour {
    static public int highScore = 0;
    [SerializeField]
    TextMeshProUGUI highScoreText;


    public void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", highScore);
    }
    public void Update()
    {
        highScoreText.text = "HighScore:"+highScore.ToString();
        if(highScore>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

}
