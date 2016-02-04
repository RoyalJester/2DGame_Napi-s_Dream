using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour {
    private Player my_player;
    void Start()
    {
        my_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    //movement to go left
    public void left_Arrow()
    {
      
         my_player.moveHor = -1;
    }

    //movement to go right
    public void right_Arrow()
    {
      
        my_player.moveHor = 1;
    }
}
