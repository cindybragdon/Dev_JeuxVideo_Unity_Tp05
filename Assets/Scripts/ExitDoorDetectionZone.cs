using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// J'ai du demander des explications à Olivier pour figurer l'implémentation de cette zone, plusieurs booléan sont pris en compte
// et j'avais du mal à organiser le tout correctement.  Je place donc cette référence ici et sur l'autre zone de détection.
public class ExitDoorDetectionZone : MonoBehaviour
{

    Animator animator;

    public bool CanOpen = false;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GameObject.Find("ExitDoor").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the tag "Player"
        if (other.CompareTag("Player") && CanOpen )
        {
            animator.SetBool("isClosed",true); // Enable the Animator to open the door
            Debug.Log("The player has entered the Door Detection Zone ");

            // Start the process of closing the door after a delay
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If the player has entered, start counting down to close the door
        if (other.CompareTag("Player") )
        {
            animator.SetBool("isClosed",false); 
            Debug.Log("The player has left the Door Detection Zone ");

        }
    }
}
