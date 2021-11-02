using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starting : MonoBehaviour 
{
	string[] args = new string[10];
    string username = "username";
    string password = "password";

	void Start ()
	{
		args = System.Environment.GetCommandLineArgs();
        Debug.Log(args[2]);
	}
	
	void OnGUI()
	{
        /*
        for(int i = 0; i < args.Length; i++)
		    GUILayout.Label(args[i]);
        */
        GUILayout.Label(args[3]);
        GUILayout.Label(args[6]);

	}

    void Update()
    {
        if (args[3] != username || args[6] != password)
        {
            Application.Quit();
        }
    }
}