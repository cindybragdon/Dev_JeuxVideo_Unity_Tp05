using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour
{
    private bool doorClosedPermanently = false; // To track if the door has been closed permanently
    private bool playerHasEntered = false;      // To track if the player has entered the trigger
    private float timer = 0f;                   // Timer to manage door closing
    public float doorCloseDelay = 3.0f;         // Delay before closing the door
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false; // Keep the animator disabled initially
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the tag "Player"
        if (other.CompareTag("Player") && !doorClosedPermanently)
        {
            animator.enabled = true; // Enable the Animator to open the door
            Debug.Log("The player has entered the trigger zone!");

            // Start the process of closing the door after a delay
            playerHasEntered = true;
        }
    }

    private void Update()
    {
        // If the player has entered, start counting down to close the door
        if (playerHasEntered && !doorClosedPermanently)
        {
            timer += Time.deltaTime;

            // Once the timer reaches the doorCloseDelay, close the door
            if (timer >= doorCloseDelay)
            {
                animator.SetTrigger("Close"); // Trigger the closing animation
                doorClosedPermanently = true; // Mark the door as closed permanently
                Debug.Log("The door is now closed permanently.");
            }
        }
    }
}
