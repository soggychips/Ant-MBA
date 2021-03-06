﻿using UnityEngine;
using System.Collections;

public class Switch_Backgrounds : MonoBehaviour {
	public Sprite new_background;
	public GUIStyle style;
	private GameObject bill_dialogue_closing;
	private bool swap;
	private bool show_credits;

	void Awake(){
		bill_dialogue_closing = GameObject.Find ("bill_dialogue_controller");
	}
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag("dialogue").Length<=1 && !swap){
			GetComponent<SpriteRenderer>().sprite = new_background;
			bill_dialogue_closing.GetComponent<Chat_text>().enabled = true;
			bill_dialogue_closing.GetComponent<Dialogue_controller>().enabled = true;
			swap = true;
		}

		if(GameObject.FindGameObjectsWithTag("dialogue").Length==0){
			Application.LoadLevel("credits");
		}
	}
	
}
