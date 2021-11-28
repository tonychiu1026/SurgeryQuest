/*
This is the file that enables command line arguments when running the exe file
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// starting is an in-game object that is hidden
// When the game launches, the object get launched, then this script get run
public class starting : MonoBehaviour 
{
    // hard-coded credentials
	string[] args = new string[10];
    string username = "username";
    string password = "password";

    // On start, get the command line arguments
	void Start ()
	{
		args = System.Environment.GetCommandLineArgs();
	}
	
    // Displayed the selected argument for debug purpose
	void OnGUI()
	{

	}

    // check if the argument input match the hard-coded credentials
    void Update()
    {
        if (args.Length != 3)
        {
            Application.Quit();
        }

        if (args[1] != username || args[2] != password)
        {
            Application.Quit();
        }
    }
}