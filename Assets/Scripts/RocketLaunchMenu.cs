﻿using UnityEngine;
using System.Collections;

public class RocketLaunchMenu : MonoBehaviour {
//
//	public GameObject GameObjToDisable01;
//	public GameObject GameObjToDisable02;
//	public GameObject GameObjToDisable03;
//	public GameObject GameObjToDisable04;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable01.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts02 = GameObjToDisable02.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts02)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts03 = GameObjToDisable03.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts03)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts04 = GameObjToDisable04.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts04)
//			{
//				script.enabled = false;
//			}
			//Application.Quit ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable01.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts02 = GameObjToDisable02.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts02)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts03 = GameObjToDisable03.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts03)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts04 = GameObjToDisable04.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts04)
//			{
//				script.enabled = false;
//			}
			Application.LoadLevel (Application.loadedLevelName);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts01 = GameObjToDisable01.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts01)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts02 = GameObjToDisable02.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts02)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts03 = GameObjToDisable03.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts03)
//			{
//				script.enabled = false;
//			}
//			//disable all sendmessageaction scripts of voice recog
//			MonoBehaviour[] scripts04 = GameObjToDisable04.GetComponents<SendMessageAction>();
//			foreach(MonoBehaviour script in scripts04)
//			{
//				script.enabled = false;
//			}
			Application.LoadLevel ("TransitScene");
		}
	}
	
	void QuitCommanded(){
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts01 = GameObjToDisable01.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts01)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts02 = GameObjToDisable02.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts02)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts03 = GameObjToDisable03.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts03)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts04 = GameObjToDisable04.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts04)
//		{
//			script.enabled = false;
//		}
		Application.Quit ();
	}
	
	void HomeCommanded(){
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts01 = GameObjToDisable01.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts01)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts02 = GameObjToDisable02.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts02)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts03 = GameObjToDisable03.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts03)
//		{
//			script.enabled = false;
//		}
//		//disable all sendmessageaction scripts of voice recog
//		MonoBehaviour[] scripts04 = GameObjToDisable04.GetComponents<SendMessageAction>();
//		foreach(MonoBehaviour script in scripts04)
//		{
//			script.enabled = false;
//		}
		Application.LoadLevel ("TransitScene");
	}
	
}