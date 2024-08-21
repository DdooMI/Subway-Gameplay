using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighscoreSubwayHandler : MonoBehaviour
{
    int highscore;
    [SerializeField] HighScoreUI highScoreUI;

    public int HighScore 
    {
        set { 
            highscore = value;
            highScoreUI.SetHighScore(value);
        
        }
    
    }
    private void Start()
    {
        SetLatestHighscore(); 
    }
    private void SetLatestHighscore() 
    {
        HighScore = PlayerPrefs.GetInt("Highscore",0);
    
    }

    private void SaveHighscore(int score) 
    {
        PlayerPrefs.SetInt("Highscore",score);
    
    }

    public void SetHighscoreIfGreatest(int score) 
    {
        if (score > highscore) 
        {
            HighScore = score;
            SaveHighscore(score);
            highScoreUI.SetHighScore(score);
        
        }
    
    
    }

}
