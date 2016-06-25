using UnityEngine;
using System.Collections;

public class roomMaker : MonoBehaviour {
	public Vector3 startingPoint, endingPoint;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	public void reset(){
		player.transform.position = startingPoint;
	}
}
