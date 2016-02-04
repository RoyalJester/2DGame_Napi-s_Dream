using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    bool characterFacingRight = true;
    public float moveHor = 0;
    //Animator characterAnimation;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //characterAnimation = GetComponent<Animator> ();
    }

    // FixedUpdate is used for Physics related actions
    void FixedUpdate()
    {
        //float moveHor = Input.GetAxis("Horizontal");

        Vector2 movedir = new Vector2(moveHor, 0.0f);
        rb.velocity = movedir * speed;


        if (moveHor > 0 && !characterFacingRight)
        {
            FlipSprite();
        }
        else if (moveHor < 0 && characterFacingRight)
        {
            FlipSprite();
        }
    }

    void FlipSprite()
    {
        // Set Character Facing Direction To Opposite or False
        characterFacingRight = !characterFacingRight;
        Vector3 currentScale = transform.localScale;

        // Multiply Current Scale By Negative To Flip Direction
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }
	public void goingleft(){
		moveHor = -1;
	}
	public void goingright(){
		moveHor = 1;
	}
}