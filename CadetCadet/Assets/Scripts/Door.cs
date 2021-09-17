using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class for doors
//Doors should have a list of requirements to open if locked
//Need to handle animation type (slow, fast, or normal)

public enum DoorSwitches
{
    One= 1,
    Two= 2,
    Three =3,
    Four = 4,
}

public class Door
{
    [SerializeField] string DoorName; 
    [SerializeField] List<bool> doorReqs;
    [SerializeField] int[] indices; //Which doors have been activated.
    int testsize;
    // Start is called before the first frame update
    void Start()
    {
        //We'll Get the information from the save file here

        //For now we'll just setup a loop
        for(int i = 0; i < 0; i++)
        {

        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
