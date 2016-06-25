﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreInitialization : MonoBehaviour {

	public UnityEngine.UI.Text RoomScore;

	// Use this for initialization
	void Start () {
		RoomScore.text = "";
		int nbRooms = GameManager.instance.NumberOfRooms;
		Debug.Log("Room number: " + nbRooms);
		for(int i = 1; i <= nbRooms; i++){
			RoomScore.text += "Room " + i + " Fails : " + PlayerPrefs.GetInt("nFailRoom" + i) + "\n";
			Debug.Log("Room " + i + " : " + PlayerPrefs.GetInt("nFailRoom" + i));
		}
	}

	public void returnToMenu(){
		GameManager.instance.LoadMenu();
	}
}
