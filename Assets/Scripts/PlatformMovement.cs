using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {
    private float speed =  3.8f;
    public Rigidbody2D platformRb;
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 movedir = new Vector2(0.0f, 1.0f);
        platformRb.velocity = movedir * speed;
    }
}
