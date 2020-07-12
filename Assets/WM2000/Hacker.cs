using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("SIDDHARTH");
    }


    void ShowMainMenu(string Name)
    {
        string name = "Siddharth Rajput";
        Terminal.ClearScreen();
        Terminal.WriteLine("HI" + name);
        print("Hello Console");
        Terminal.WriteLine("HACK THIS TERMINAL {**}");
        Terminal.WriteLine("Press 1 for your Local Host Library");
        Terminal.WriteLine("Press 2 for your Server Host Library");
        Terminal.WriteLine("Press 3 for your Doing nothing");
        Terminal.WriteLine("ENTER YOUR CHOICE:");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
