using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipefour : MonoBehaviour
{
    public float raycastLength = 10f; // Length of the raycast
    public bool connect4 = false;
    public GameObject connecter1;
    public GameObject connecter2;


    public GameObject water1;
    public GameObject water2;


    //public connecterDistributer connectDis;

    void Update()
    {

        RaycastHit2D hit1 = Physics2D.Raycast(connecter1.transform.position, transform.up, raycastLength);

        Debug.DrawRay(connecter1.transform.position, transform.up * raycastLength, Color.red);

        RaycastHit2D hit2 = Physics2D.Raycast(connecter2.transform.position, -transform.right, raycastLength);

        Debug.DrawRay(connecter2.transform.position, -transform.right * raycastLength, Color.red);

        if (connect4)
        {

            if (hit1.collider != null || hit2.collider != null)

            {
                print (hit1.collider);
                CheckCollision(hit1);
                CheckCollision(hit2);

            }
            else if (hit1.collider == null || hit2.collider == null)
            {
                // connectDis =GetComponentInParent<connecterDistributer>();
                 //connectDis.pipeOneMethodfalse();
                 water1.SetActive(false);
                water2.SetActive(false);
                connect4 = false;
            }

            DisableWaterBasedOnHit(hit1, water1);
            DisableWaterBasedOnHit(hit2, water2);

        }
        else if (connect4 == false)
        {
            water1.SetActive(false);
            water2.SetActive(false);

        }
    }

    void CheckCollision(RaycastHit2D hit)
    {

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("pipezero"))
            {
                Debug.Log("Pipe zero hit");

            }
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
            else if (hit.collider.CompareTag("pipefinal"))
            {
                connecterDistributer objectScript = hit.collider.GetComponent<connecterDistributer>();
                if (objectScript != null)
                {
                    objectScript.finalpipe();
                }
            }
        }
    }
    void DisableWaterBasedOnHit(RaycastHit2D hit, GameObject water)
    {
        if (hit.collider != null)
        {
            // If a raycast hits, disable the associated water GameObject
            water.SetActive(false);
        }
        else
        {
            // If no hit, enable the associated water GameObject
            water.SetActive(true);
        }
    }
}
