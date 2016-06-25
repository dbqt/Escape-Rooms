using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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

    public void TogglePause()
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
        if(Rooms.Length <= 0) return; //abord!

        int nextRoom = Random.Range(0, Rooms.Length);
        SceneManager.LoadScene(Rooms[nextRoom].name);
    }
}
