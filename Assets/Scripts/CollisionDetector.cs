using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public bool isGrounded = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
            Debug.Log("Player 1 is grounded!");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
            Debug.Log("Player 1 is no longer grounded!");
        }
    }

    public bool getIsGrounded()
    {
        return isGrounded;
    }
}

