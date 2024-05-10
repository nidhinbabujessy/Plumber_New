using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connecterDistributer : MonoBehaviour
{
    public PipeOne pipeOne;
    public PipeTwo pipeTwo;
    public PipeThree pipeThree;
    public pipefour pipeFour;
    public Pipefive pipeFive;
    public finalpipe FinalPipe;
    
   
   

   
    void Start()
    {
        pipeOne = GameObject.FindObjectOfType<PipeOne>();
        pipeTwo = GameObject.FindObjectOfType<PipeTwo>();
        pipeThree = GameObject.FindObjectOfType<PipeThree>();
        pipeFour = GameObject.FindObjectOfType<pipefour>();
        pipeFive = GameObject.FindObjectOfType<Pipefive>();
        FinalPipe =GameObject.FindObjectOfType<finalpipe>();

        
        if (pipeOne == null)
            Debug.LogError("PipeOne component not found!");

        
        pipeTwo = GameObject.FindObjectOfType<PipeTwo>();

        
        if (pipeTwo == null)
            Debug.LogError("PipeTwo component not found!");

        
        pipeThree = GameObject.FindObjectOfType<PipeThree>();

        
        if (pipeThree == null)
            Debug.LogError("PipeThree component not found!");
    }

   
    public void AllDisable()
    {
        pipeOne.connect = false;
        pipeTwo.connect2 = false;
       pipeThree.connect3 = false;
        print("all disables");
    }
   public void pipeOneMethod()
    {
       
        pipeOne.connect = true;
        print("pipeone method");
    }
    public void pipeOneMethodfalse()
    {
        pipeThree.connect3 = false;
    }
    public void pipeOneMethod2()
    {
        print("pipeOnemethod called");
        pipeOne.connect = false;
        pipeTwo.connect2=false;
        pipeThree.connect3 = false;
        pipeFive.connect5= false;
    }
    public void pipeTwoMethod()
    {
        
       // pipeTwo.connect2 = true;
        print("pipetwo method");
    }
    public void pipeThreeMothed()
    {
       pipeThree.connect3 = true;
        print("pipethree mothod called");
    }
    public void pipeFourMethod()
    {
        pipeFour.connect4 = true;
        print("pipefour mothod called");
    }
    public void pipefivemethod()
    {
        pipeFive.connect5 = true;
    }
    public void finalpipe()
    {
        FinalPipe.finalPipe = true;
        print("final pipe called");
    }
}
