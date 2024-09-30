using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPlayer : MonoBehaviour
{
    //https://discussions.unity.com/t/detect-if-player-is-in-range/99984
    public GameObject player;
    Animator creatureAnimator;
    public int maxRange;
    public int minRange;
    public List<AudioClip> listAudioClip;

    public AudioSource audioSource;
    private bool isOnTimePlay;

    
    public Slider sliderCoeur;
    public Text textCoeur; 
    public float timelapseAttack = 0;
    public float timeBeforeDealDamage = 2f;

    public float valueDamage = 30f;


    // Start is called before the first frame update
    void Start()
    {
        creatureAnimator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(transform.position, player.transform.position) < maxRange)
           && (Vector3.Distance(transform.position, player.transform.position) > minRange))
        {

            timelapseAttack += Time.deltaTime;
            print(timelapseAttack);

            if(timelapseAttack >= timeBeforeDealDamage) {
                sliderCoeur.value -= valueDamage;
                textCoeur.text = sliderCoeur.value + "%";
                timelapseAttack = 0;
            }

            creatureAnimator.SetBool("Attack", true);
            if (!isOnTimePlay) {
                audioSource.PlayOneShot(listAudioClip[Random.Range(0, listAudioClip.Count)]);
                isOnTimePlay = true;
            }

        } else {
            creatureAnimator.SetBool("Attack", false);
            isOnTimePlay = false;
            timelapseAttack = 0;
            
        }
    }
}