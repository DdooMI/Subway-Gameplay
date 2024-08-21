using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameConnect : MonoBehaviour
{
    private static NameConnect instance;

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
