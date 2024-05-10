using Unity.VisualScripting;
using UnityEngine;

public class PipeTwo : MonoBehaviour
{
    public float raycastLength = 10f; // Length of the raycast
    public bool connect2 = false;
    public GameObject connecter1;
    public GameObject connecter2;
    public GameObject connecter3;
   // public GameObject connecter4;

    public GameObject water1;
    public GameObject water2;
    public GameObject water3;
    // public GameObject water4;

    public connecterDistributer otherScript;
    public connecterDistributer otherScript2;
    public connecterDistributer otherScript3;
    public connecterDistributer otherScript4;

    void Update()
    {
       
        RaycastHit2D hit2 = Physics2D.Raycast(connecter1.transform.position, -transform.right, raycastLength);
        Debug.DrawRay(connecter1.transform.position, -transform.right * raycastLength, Color.red);

        RaycastHit2D hit3 = Physics2D.Raycast(connecter2.transform.position, -transform.up, raycastLength);

        Debug.DrawRay(connecter2.transform.position, -transform.up * raycastLength, Color.red);

        RaycastHit2D hit4 = Physics2D.Raycast(connecter3.transform.position, transform.up, raycastLength);

        Debug.DrawRay(connecter3.transform.position, transform.up * raycastLength, Color.red);

        if (connect2)
        {
            if (hit2.collider != null || hit3.collider != null || hit4.collider != null)
            {
                //CheckCollision(hit);
                CheckCollision(hit2);
                CheckCollision(hit3);
                CheckCollision(hit4);
            }
            else if(hit2.collider == null || hit3.collider == null || hit4.collider == null)
            {
                print("no collids in pipe 2");

                water1.SetActive(false);
                water2.SetActive(false);
                water3.SetActive(false);
                connect2 = false;
                
            }
            // DisableWaterBasedOnHit(hit, water1);
            DisableWaterBasedOnHit(hit2, water1);
            DisableWaterBasedOnHit(hit3, water2);
            DisableWaterBasedOnHit(hit4, water3);
        }
         if (connect2 == false)
        {
            water1.SetActive(false);
            water2.SetActive(false);
            water3.SetActive(false);
          //  water4.SetActive(false);
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
            water.SetActive(false);
        }
        else
        {
            water.SetActive(true);
        }
    }
}
