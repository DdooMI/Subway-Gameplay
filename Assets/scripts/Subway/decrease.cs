using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decrease : MonoBehaviour
{
    [SerializeField] Player player;
    public AudioSource SlowAudio;
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
        player.speed -= 5;
        SlowAudio.Play();
        this.gameObject.SetActive(false);
    }
}
