using UnityEngine;
using System.Collections;

public class RandomTripleFallingFloor : MonoBehaviour {
	public GameObject fallingFloor1, fallingFloor2, fallingFloor3;
	// Use this for initialization
	void Start () {
		fallingFloor1.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 0f, -2.55f);
		fallingFloor2.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 0f, 0.08f);
		fallingFloor3.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 0f, 2.84f);
	}
}
