using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class createSection : MonoBehaviour
{
    public GameObject player;
    public GameObject section;
    public int zPos = 80;
    public bool create = false;
    GameObject[] coins;
    GameObject[] healsup;
    GameObject[] decreases;

    private void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("coin");
        healsup = GameObject.FindGameObjectsWithTag("heal");
        decreases = GameObject.FindGameObjectsWithTag("decrease");
        
    }
    // Update is called once per frame
    void Update()
    {
        if (create == false) 
        {
            create = true;
            StartCoroutine(CreateSec());
            foreach (GameObject coin in coins)
            {
                if (player.GetComponent<Player>().enabled == false)
                {
                    coin.SetActive(false);
                }
                else
                {
                    coin.SetActive(true);
                }

            }
            foreach (GameObject heal in healsup)
            {
                if (player.GetComponent<Player>().enabled == false)
                {
                    heal.SetActive(false);
                }
                else
                {
                    heal.SetActive(true);
                }

            }
            foreach (GameObject decrease in decreases)
            {
                if (player.GetComponent<Player>().enabled == false)
                {
                    decrease.SetActive(false);
                }
                else
                {
                    decrease.SetActive(true);
                }

            }
        }
    }

    IEnumerator CreateSec() 
    {
        Instantiate(section,new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 80;
        yield return new WaitForSeconds(4);
        create = false;
    }

}
