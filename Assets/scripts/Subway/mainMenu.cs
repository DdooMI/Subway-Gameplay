using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour
{
    [SerializeField] GameObject HighScorePage;
    [SerializeField] GameObject settingPage;
    [SerializeField] GameObject elementPrefab;
    [SerializeField] Transform elementWapper;

    public Text PlayerName;
    public GameObject PlayerWarning;
    public Slider Game;
    public AudioSource GameAudio;
 

    List<GameObject> uiElements = new List<GameObject>();

    private void OnEnable()
    {
        HighScoreHandler.OnhighscorelistChanged += UpdateUI;
    }
    private void OnDisable()
    {
        HighScoreHandler.OnhighscorelistChanged -= UpdateUI;
    }
    private void UpdateUI(List<HighScoreElement> list) 
    {
        for (int i = 0; i < list.Count; i++) 
        {
            HighScoreElement element = list[i];

            if (element.score > 0) 
            {
                if (i >= uiElements.Count) 
                {
                    var inst = Instantiate(elementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWapper);
                    uiElements.Add(inst);
                }
                var texts = uiElements[i].GetComponentsInChildren<Text>();
                texts[0].text = element.Playername.ToString();
                texts[1].text = element.score.ToString();
            }
        
        }
    
    }

    private void Start()
    {
 
    }

    public void PlayGame() 
    {
        if (PlayerName.text == "")
        {
            PlayerWarning.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void PlayGameBack() 
    {
        PlayerWarning.SetActive(false);    
    }

    public void HighScore()
    {
        HighScorePage.SetActive(true);   
    }
    public void HighScoreBack()
    {
        HighScorePage.SetActive(false);
    }
    public void Settings()
    {
        settingPage.SetActive(true);
    }
    public void SettingBack()
    {
        settingPage.SetActive(false);
    }
    public void Exit() 
    {
        Application.Quit();
    
    }
    public void GameSetting()
    {

        //Game
        if (Game.value == 0)
        {
            GameAudio.volume = 0;        
        }
        if (Game.value > 0 && Game.value < 0.1)
        {
            GameAudio.volume = 0.1f;       
        }
        if (Game.value >= 0.1 && Game.value < 0.2)
        {
            GameAudio.volume = 0.2f;  
        }
        if (Game.value >= 0.2 && Game.value < 0.3)
        {
            GameAudio.volume = 0.3f;
        }
        if (Game.value >= 0.3 && Game.value < 0.4)
        {
            GameAudio.volume = 0.4f;
        }
        if (Game.value >= 0.4 && Game.value < 0.5)
        {
            GameAudio.volume = 0.5f;
        }
        if (Game.value >= 0.5 && Game.value < 0.6)
        {
            GameAudio.volume = 0.6f;
        }
        if (Game.value >= 0.6 && Game.value < 0.7)
        {
            GameAudio.volume = 0.7f;
        }
        if (Game.value >= 0.7 && Game.value < 0.8)
        {
            GameAudio.volume = 0.8f;
        }
        if (Game.value >= 0.8 && Game.value < 0.9)
        {
            GameAudio.volume = 0.9f;      
        }
        if (Game.value >= 0.9 && Game.value < 1)
        {
            GameAudio.volume = 1;
        }    
    }
}
