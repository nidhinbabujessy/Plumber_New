using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connecterTwo : MonoBehaviour
{
    private PipeThree _pipeThree;

    //private void Start()
    //{
    //    _pipeThree = GetComponent<PipeThree>();
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Connecter"))
    //    {
    //        _pipeThree.connecter2 = true;
    //        Debug.Log("Collision Connecter2");
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered trigger collider: " + other.gameObject.name);
    }
}
