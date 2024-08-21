using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    [SerializeField] HighScoreHandler highScoreHandler;
    [SerializeField] HighscoreSubwayHandler scoreHandler;
    string NameP;
    GameObject Playername;
    public GameObject coins;
    public GameObject runner;
    public GameObject endScreen;
    public GameObject outro;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndScreen());
        Playername = GameObject.Find("name");
        NameP = Playername.GetComponent<PlayerName>().playerNAme;
    }
    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(3);
        coins.SetActive(false);
        runner.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(1);
        outro.SetActive(true);
        yield return new WaitForSeconds(3);
        highScoreHandler.AddHighscoreifPossible(new HighScoreElement(NameP,CollectCoin.count));
        scoreHandler.SetHighscoreIfGreatest(CollectCoin.count);
        CollectCoin.count = 0;
        Gameconnect gameManager = FindObjectOfType<Gameconnect>();
        Destroy(gameManager.gameObject);
        NameConnect nameManager = FindObjectOfType<NameConnect>();
        Destroy(nameManager.gameObject);
        SceneManager.LoadScene(0);
    }

}
