using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class KeyScript : MonoBehaviour
{
    public List<AudioClip> listAudioClip;

    public AudioSource audioSource;

 
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Player"){
            GameObject.Find("ExitDoor").GetComponent<ExitDoor>().CanOpen=true;
            GameObject.FindGameObjectWithTag("KeyAudio").GetComponent<AudioSource>().PlayOneShot(listAudioClip[Random.Range(0, listAudioClip.Count)]);
            Destroy(gameObject);
            print("Canopen true");
        }
    }
}