﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int max = 1000,min = 1;
          
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pink an number,don't tell me what it is..");
        Debug.Log("The highest number you can pick is: "+max);
        Debug.Log("The lowest number you can pick is: "+min);
        Debug.Log("Tell me if your number is higher or lower then 500");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        //print("Helu! Sani!? ");
        ;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            Debug.Log("Up Arrow key was pressed.");
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arror key was pressed");
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
        }
    }
}
