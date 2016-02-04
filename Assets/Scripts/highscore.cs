using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscore : MonoBehaviour {

	public Text highscores;
	public AudioSource audio;
	private int count;
	
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		count = 0;
		setHighScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag ( "point"))
        {
            count = count + 1;
			audio.Play();
            setHighScore ();
        }
		if (other.gameObject.CompareTag ( "Finish"))
        {
			if(count > PlayerPrefs.GetInt("PlayerScore")){
			PlayerPrefs.SetInt("PlayerScore",count);
			}
            SceneManager.LoadScene(0);
        }
	
    }
	
	public void setHighScore(){
		 highscores.text = "HIGHSCORE : " + count.ToString ();
	}
}
