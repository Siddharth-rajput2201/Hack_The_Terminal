using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.ClearScreen();
        print("Hello Console");
        Terminal.WriteLine("HACK THIS TERMINAL {**}");
        Terminal.WriteLine("Press 1 for your Local Host Library...");
        Terminal.WriteLine("Press 2 for your Server Host Library...");
        Terminal.WriteLine("Press 3 for your Doing nothing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
