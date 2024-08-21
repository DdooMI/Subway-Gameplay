using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public AudioSource CoinAudio;
    public Text Score;
    public Text EndScore;
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,1,0,Space.World);
        Score.text = "" + count;
        EndScore.text = "" + count;
   
    }

    private void OnTriggerEnter(Collider other)
    {
        CoinAudio.Play();
        count+=1;
        this.gameObject.SetActive(false);
    }
}
