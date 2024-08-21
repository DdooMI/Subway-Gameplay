using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameconnect : MonoBehaviour
{
    // Start is called before the first frame update
    private static Gameconnect instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
