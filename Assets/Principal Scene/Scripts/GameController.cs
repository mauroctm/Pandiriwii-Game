using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour {
    /* This is time generl of game */
    private DateTime time = DateTime.Now;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getHours() {
        return 14;
        //return this.time.Hour;
    }

    public int getMinute()
    {
        return this.time.Minute;
    }

}
