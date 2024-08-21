using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public GameObject main;
    public Text textName;
    public string playerNAme;
    public void Save() 
    {
        playerNAme = textName.text;
    }
}
