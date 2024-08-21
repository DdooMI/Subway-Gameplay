using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Run : MonoBehaviour
{
    public Text Runnig;
    public Text EndRunnig;
    public int RunCount;
    public bool add;
  
    // Update is called once per frame
    void Update()
    {
        if (add == false)
        {
            add = true;
            StartCoroutine(Runner());
        
        }
    }
    IEnumerator Runner() 
    {
        RunCount++;
        Runnig.text = "" + RunCount;
        EndRunnig.text = "" + RunCount;
        yield return new WaitForSeconds(0.2f);
        add = false;
    }
}
