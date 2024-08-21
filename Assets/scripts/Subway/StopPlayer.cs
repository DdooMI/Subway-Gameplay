using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject Anime;
    public AudioSource Crash;
    public GameObject mainCamera;
    public GameObject stopRunning;
    public GameObject EndGame;
    

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<Player>().enabled = false;
        stopRunning.GetComponent<Run>().enabled = false;
        Anime.GetComponent<Animator>().Play("Stumble Backwards");
        Crash.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        EndGame.GetComponent<End>().enabled = true;
      
    }
}
