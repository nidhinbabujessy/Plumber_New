using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalpipe : MonoBehaviour
{
    public GameObject water;
    public bool finalPipe = false;
    public GameObject WinWindow;
    public GameObject time;

    void Start()
    {
        WinWindow.SetActive(false);
        time.SetActive(true);
    }
    void Update()
    {

        if (finalPipe == true)
        {
            water.SetActive(true);
            print("win");
            StartCoroutine(WaitForTwoSeconds());
           
        }
        else
        {
            water.SetActive(false);
        }
    }
    IEnumerator WaitForTwoSeconds()
    {

        yield return new WaitForSeconds(2f);
        WinWindow.SetActive(true);
        time.SetActive(false);


    }
}