using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScoreHandler : MonoBehaviour
{
    List<HighScoreElement> highscorelist = new List<HighScoreElement>();
    [SerializeField] int maxCount = 5;
    [SerializeField] string filename;

    public delegate void OnHighscoreListChanged(List<HighScoreElement> list);
    public static event OnHighscoreListChanged OnhighscorelistChanged;
    void Start()
    {
        LoadHighscores();

    }
    private void LoadHighscores()
    {
        highscorelist = FileHandler.ReadListFromJSON<HighScoreElement>(filename);

        while (highscorelist.Count > maxCount) 
        {
            highscorelist.RemoveAt(maxCount);
        }

        if (OnhighscorelistChanged != null) 
        {
            OnhighscorelistChanged.Invoke(highscorelist);
        }
    }

    private void SaveHighScore()
    {
        FileHandler.SaveToJSON<HighScoreElement>(highscorelist,filename);
    
    }

    public void AddHighscoreifPossible(HighScoreElement element) 
    {
        for (int i = 0; i < maxCount; i++) 
        {
            if (i >= highscorelist.Count || element.score > highscorelist[i].score)
            {
                highscorelist.Insert(i,element);
                while (highscorelist.Count > maxCount)
                {
                    highscorelist.RemoveAt(maxCount);

                }
                SaveHighScore();

                if (OnhighscorelistChanged != null)
                {
                    OnhighscorelistChanged.Invoke(highscorelist);
                }

                break;
            }
        
        }
    
    }



    
  

   
}
