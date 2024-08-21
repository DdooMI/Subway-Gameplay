using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class health : MonoBehaviour
{
    [SerializeField] Player player;
    public AudioSource healUP;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        player.speed +=5;
        healUP.Play();
        this.gameObject.SetActive(false);
    }
}
