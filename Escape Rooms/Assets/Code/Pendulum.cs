using UnityEngine;
using System.Collections;

public class Pendulum : MonoBehaviour {

    public float MaxAngle, SwingSpeed;

    private int cycle;

	// Use this for initialization
	void Start () {
	   cycle = 0;
	}
	
	// Update is called once per frame
	void Update () {
	   if(cycle == 0)
       {
            SwingRight();
            if(transform.rotation.eulerAngles.z > MaxAngle && transform.rotation.eulerAngles.z < 360f - MaxAngle)
            {
                cycle = 1;
            }
       }
       else
       {
            SwingLeft();
            if(transform.rotation.eulerAngles.z > MaxAngle && transform.rotation.eulerAngles.z < 360f - MaxAngle)
            {
                cycle = 0;
            }
       }
	}

    private void SwingRight()
    {
        transform.Rotate(new Vector3(0f, 0f, SwingSpeed*Time.deltaTime));
    }

    private void SwingLeft()
    {
        transform.Rotate(new Vector3(0f, 0f, -SwingSpeed*Time.deltaTime));
    }
}
