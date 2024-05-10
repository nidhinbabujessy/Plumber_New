using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public GameObject water;
    public float raycastLength = 10f;
    public connecterDistributer otherScript;
    public connecterDistributer otherScript2;
    public connecterDistributer otherScript3;
    public connecterDistributer otherScript4;
    public connecterDistributer otherScript5;// Reference to the script containing the method to call

    void Update()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, raycastLength);
        Debug.DrawRay(transform.position, -transform.up * raycastLength, Color.red);

        
        if (hit.collider != null)
        {
            water.SetActive(false);
            Debug.Log("Hit object: " + hit.collider.gameObject.name);

           
            if (hit.collider.CompareTag("Pipeone"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.pipeOneMethod();
                }
            }
            
            else if (hit.collider.CompareTag("pipetwo"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.pipeTwoMethod();
                }
            }
            
            else if (hit.collider.CompareTag("pipethree"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.pipeThreeMothed();
                }
            }
            else if (hit.collider.CompareTag("pipefour"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.pipeFourMethod();
                }
            }
            else if (hit.collider.CompareTag("pipefive"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.pipefivemethod();
                }
            }
        }
        else
        {
            
            otherScript.pipeOneMethod2();
            otherScript2.pipeOneMethod2();
            otherScript3.pipeOneMethod2();
            otherScript4.pipeOneMethod2();
            otherScript5.pipeOneMethod2();
            water.SetActive(true);
        }
    }
}
