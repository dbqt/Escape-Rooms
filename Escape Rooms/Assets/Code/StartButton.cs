using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

    public void StartAction()
    {
        GameManager.instance.StartNewGame();
    }
}
