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
        Debug.Log(args[2]);
	}
	
    // Displayed the selected argument for debug purpose
	void OnGUI()
	{
        /*
        for(int i = 0; i < args.Length; i++)
		    GUILayout.Label(args[i]);
        */
        GUILayout.Label(args[3]);
        GUILayout.Label(args[6]);

	}

    // check if the argument input match the hard-coded credentials
    void Update()
    {
        if (args[3] != username || args[6] != password)
        {
            Application.Quit();
        }
    }
}