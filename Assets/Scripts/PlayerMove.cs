using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX*moveSpeed,rb.velocity.y);

        // Jumping
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true; 
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player collides with a platform set jumping to false
        if(collision.gameObject.CompareTag("Platform"))
        {
            isJumping = false;
            Debug.Log("Collided.");
        }
    }


}
