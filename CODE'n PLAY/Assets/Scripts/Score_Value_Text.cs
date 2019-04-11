using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Value_Text : MonoBehaviour {
    private string text;
	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindWithTag("Player") != null)
        {
            GetComponent<Text>().text = "" + GameObject.FindWithTag("Player").GetComponent<Player_Sphere_Script>().get_score();
        }
	}
}
