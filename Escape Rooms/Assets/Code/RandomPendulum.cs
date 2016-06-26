using UnityEngine;
using System.Collections;

public class RandomPendulum : MonoBehaviour {
	public GameObject Pendulum1, Pendulum2, Pendulum3;
	// Use this for initialization
	void Start () {
		int random = Random.Range(1, 8);
		bool pendulum1Enabled = ((random%2 == 1) ? true : false),
			 pendulum2Enabled = (((random/2)%2 == 1) ? true : false),
			 pendulum3Enabled = (((random/4)%2 == 1) ? true : false);

		Pendulum1.SetActive(pendulum1Enabled);
		Pendulum2.SetActive(pendulum2Enabled);
		Pendulum3.SetActive(pendulum3Enabled);
	}
}
