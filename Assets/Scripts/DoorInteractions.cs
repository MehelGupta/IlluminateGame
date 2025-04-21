using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractions : MonoBehaviour
{
    public GameObject button;
    public float interactDistance = 2f;
    private bool nearDoor = false;
    // Start is called before the first frame update
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E) && nearDoor)
       {
            Debug.Log("Player Can Enter the Door (when you code it lmao)");
       } 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            if(Vector2.Distance(transform.position, button.transform.position) < interactDistance)
            {
                nearDoor = true;
            }
            else
            {
                nearDoor = false;
                Debug.Log("Player is too far from the button!");
            }
        }
    }
}
