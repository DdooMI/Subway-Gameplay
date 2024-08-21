using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] Text highscoreText;
    public void SetHighScore(int score) 
    {
        highscoreText.text = score.ToString();
    }

}
