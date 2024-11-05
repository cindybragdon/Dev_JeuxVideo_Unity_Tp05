using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class JumpToPlayer : MonoBehaviour
{

    NavMeshLink navMeshLink;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        navMeshLink = GetComponent<NavMeshLink>();
    }

    // Update is called once per frame
    void Update()
    {
   
        navMeshLink.endPoint = player.transform.position;

    }
}
