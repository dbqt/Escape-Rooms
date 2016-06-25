using UnityEngine;
using System.Collections;

public class EndLevelLogic : MonoBehaviour {

	void OnTriggerEnter(Collider o)
    {
        if(o.gameObject.tag == "Player")
        {
            GameManager.instance.EndLevel(true);
        }
    }
}
