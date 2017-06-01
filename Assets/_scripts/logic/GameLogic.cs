using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {
    

    public enum GameLogicState
    {
        NONE,
        LOADING,
        START,
        PLAYING,
        OVER,
        HELP,

    }

    private GameLogicState m_state = GameLogicState.NONE;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void UpdateLogicState (GameLogicState state) 
    {
        if (state == m_state)
            return;

        switch (state)
        {
            case GameLogicState.LOADING:

                break;

            case GameLogicState.START:
                SceneManager.LoadSceneAsync("start");
                break;

            case GameLogicState.PLAYING:
                SceneManager.LoadSceneAsync("main");
                break;

            case GameLogicState.OVER:
                SceneManager.LoadSceneAsync("over");
                break;

            case GameLogicState.HELP:
                SceneManager.LoadSceneAsync("help");
                break;
        
        
        }
		
	}


}
