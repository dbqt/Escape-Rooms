using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    static public GameManager instance = null;

    public int NumberOfRooms;
    public GameObject playerPrefab;
    public string[] Rooms;

    private GameObject player;
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

    public void StartNewGame()
    {
        LoadNextLevel();
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        if(isPaused)
        {
            Pause();
        }
        else
        {
            UnPause();
        }
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    public GameObject GetPlayer()
    {
        return Instantiate(playerPrefab) as GameObject;
    }

    public void EndLevel(bool isSuccess)
    {
        if(isSuccess)
        {
            int successes = PlayerPrefs.GetInt("nSuccess");
            PlayerPrefs.SetInt("nSuccess", successes+1);
            NumberOfRooms--;
            if(NumberOfRooms == 0)
            {
                LoadMenu();
            }
            else
            {
                LoadNextLevel();
            }
        }
        else
        {
            int fails = PlayerPrefs.GetInt("nFail");
            PlayerPrefs.SetInt("nFail", fails+1);
            LoadMenu();
        }
    }

    public void RedoLevel()
    {
        GameObject.Find("Room").GetComponent<roomMaker>().reset();
    }

    private void LoadMenu()
    {
        Pause();
        SceneManager.LoadScene("StartMenu");
    }

    private void LoadNextLevel()
    {
        Pause();
        
        if(Rooms.Length <= 0) return; //abord!

        int nextRoom = Random.Range(0, Rooms.Length);
        SceneManager.LoadScene(Rooms[nextRoom]);
    }


}
