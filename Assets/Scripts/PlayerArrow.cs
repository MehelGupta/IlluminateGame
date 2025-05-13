using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerArrow : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpingPower = 16f;
    private bool isFacingRight = false;
    public SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rb;
    //out of world items
    public float fallZone; //limit of how far before they spawn back
    public Transform playerSpawnPoint;
    //platforms and jumping
    private bool isGrounded;

    

    void Update()
    {
        //checks if fell out of world
        if(transform.position.y < fallZone)
        {
            rb.velocity = Vector3.zero;
            Respawn();
        }
        //Player xy movement
        if(Input.GetKey(KeyCode.LeftArrow))
        {
           horizontal = -2f; 
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           horizontal = 2f; 
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
           horizontal = 0f; 
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
           horizontal = 0f; 
        }

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        /*
        if (Input.GetKey(KeyCode.UpArrow) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        */

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    //Flips sprite when facing other direction
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }
    //Teleports player to spawn 
     private void Respawn()
    {
        transform.position = playerSpawnPoint.position;
    }
    //checks if grounded
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
            Debug.Log("Player 2 is grounded!");
        }
    }
    //checks if not grounded
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
            Debug.Log("Player 2 is no longer grounded!");
        }
    }
}