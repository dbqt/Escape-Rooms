using UnityEngine;
using System.Collections;

public class roomMaker : MonoBehaviour {
	public Transform startingPoint, endingPoint;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	public void reset(){
		player.transform.position = startingPoint.position;
	}
}
