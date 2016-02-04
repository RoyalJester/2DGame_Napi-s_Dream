using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour {

	public void quit_Pressed()
    {
        SceneManager.LoadScene(0);
    }
}
