using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	private int score;
	public Text myhighscore;
	
	public void Start(){
		score = PlayerPrefs.GetInt("PlayerScore");
		myhighscore.text = "HIGHSCORE : " + score.ToString ();
		
	}
    //Starts the game
	public void play_Pressed()
    {
        SceneManager.LoadScene(1);    
    }

    //Exits the Game
    public void exit_Pressed()
    {
        Application.Quit();
    }
}
