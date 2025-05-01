using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractions : MonoBehaviour
{
    public GameObject door;
    public GameObject player1;
    public GameObject player2;
    public GameObject eTextRedcat, eTextBluecat;
    public float interactDistance = 2f;
    private bool player1NearDoor = false;
    private bool player2NearDoor = false;
    // Start is called before the first frame update
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E) && player1NearDoor)
       {
            Debug.Log("Player1 Can Enter the Door (when you code it lmao)");
            player1.SetActive(false);
            
       } 
       if(Input.GetKeyDown(KeyCode.RightShift) && player2NearDoor)
       {
            Debug.Log("Player2 Can Enter the Door (when you code it lmao)");
            player2.SetActive(false);
       }

       if(player1.activeSelf == false && player2.activeSelf == false)
       {
            SceneManager.LoadScene("Level2");
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.CompareTag("Player1"))
        {

            if(Vector2.Distance(transform.position, door.transform.position) < interactDistance)
            {
                eTextRedcat.SetActive(true);
                player1NearDoor = true;
            }
            else
            {
                player1NearDoor = false;
                Debug.Log("Player2 is too far from the button!");
            }
        }
        if(collision.CompareTag("Player2"))
        {

            if(Vector2.Distance(transform.position, door.transform.position) < interactDistance)
            {
                eTextBluecat.SetActive(true);
                player2NearDoor = true;
            }
            else
            {
                player2NearDoor = false;
                Debug.Log("Player2 is too far from the button!");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player1"))
        {
            eTextRedcat.SetActive(false);
        }
        if(collision.CompareTag("Player2"))
        {
            eTextBluecat.SetActive(false);
        }
    }
}
