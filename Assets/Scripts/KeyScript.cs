using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class KeyScript : MonoBehaviour
{
 
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player"){
            GameObject.Find("Door").GetComponent<ExitDoor>().CanOpen=true;
            Destroy(gameObject);
            print("Canopen true");
        }
    }
}