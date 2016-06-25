using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    static public GameManager instance = null;

    public GameObject player;
    public string[] Rooms;

    private bool isPaused;
    private float timer;

	// Use this for initialization
	void Start () 
    {
        // singleton logic
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
       
        isPaused = true;
        PlayerPrefs.SetInt("nSuccess", 0);
        PlayerPrefs.SetInt("nFail", 0);
        Time.timeScale = 0f;
        timer = 0f;

	}
	
	// Update is called once per frame
	void Update () 
    {
        if(!isPaused)
        {
            timer += Time.deltaTime;
        }
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
            int successes = PlayerPrefs.GetInt("nSuccess");
            PlayerPrefs.SetInt("nSuccess", successes+1);
            LoadNextLevel();
        }
        else
        {
            int fails = PlayerPrefs.GetInt("nFail");
            PlayerPrefs.SetInt("nFail", fails+1);
            LoadMenu();
        }
    }

    private void LoadMenu()
    {
        TogglePause(); 
        //SceneManager.LoadScene("menu");
    }

    private void LoadNextLevel()
    {
        TogglePause();
        
        if(Rooms.Length <= 0) return; //abord!

        int nextRoom = Random.Range(0, Rooms.Length);
        SceneManager.LoadScene(Rooms[nextRoom]);
    }
}
