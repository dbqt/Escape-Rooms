using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject[] Rooms;

    private bool isPaused;

	// Use this for initialization
	void Start () 
    {
	   isPaused = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    //check if player is dead
        // if(!player.GetComponent<>().)
        {
        //    EndLevel(false);
        }
        
        //check if player has done level
        //if((player.GetComponent<>().))
        {
        //  EndLevel(true);
        }
	}

    public voiid TogglePause()
    {
        isPaused = !isPaused;
        if(isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    private void EndLevel(bool isSuccess)
    {
        if(isSuccess)
        {
            LoadNextLevel();
        }
        else
        {
            LoadMenu();
        }
    }

    private void LoadMenu()
    {
        //SceneManager.LoadScene("menu");
    }

    private void LoadNextLevel()
    {
        if(Rooms.Count <= 0) return; //abord!

        int nextRoom = Random.Range(0, Rooms.Count);
        SceneManager.LoadScene(Rooms[nextRoom].name);
    }
}
