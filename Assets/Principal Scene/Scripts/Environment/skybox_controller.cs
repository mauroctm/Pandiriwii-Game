using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox_controller : MonoBehaviour {
    //Gamer Controller
    public GameController game_controller;
    // Use this for initialization
    public Material skybox_morning;
    public Material skybox_afternoon;
    public Material skybox_night;
    public Light principal_light;
    void Start () {
        Skybox_update();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Skybox_update() {
        int hours = game_controller.getHours();
        if (hours >= 7 && hours < 13) {
            RenderSettings.skybox = skybox_morning;
            principal_light.intensity = 1.0f;
            Debug.Log("Mornig");
        }
        if (hours >= 13 && hours < 19)
        {
            RenderSettings.skybox = skybox_afternoon;
            principal_light.intensity = 0.7f;
            Debug.Log("Afternoon");
        }
        if (hours >= 19 || hours <= 6)
        {
            RenderSettings.skybox = skybox_night;
            principal_light.intensity = 0.2f;
            Debug.Log("Night");
        }

    }
}
