using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class IA_ennemy : MonoBehaviour
{
    Animator enemyAnimator;
    [SerializeField] Transform target;
    NavMeshAgent agent;
 
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemyAnimator = GetComponent<Animator>();
        
    }
 
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        enemyAnimator.SetBool("Attack",true);
    }
}