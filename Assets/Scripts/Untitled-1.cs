/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{ 
    NavMeshAgent nm;
    public Transform target;
    public enum AIState {idle , chasing , attack};
    public AIState aiState = AIState.idle;
    public float distancethreshold = 10f;
    public Animator zombiemovement;
    public float attackthreshold = 2f;
    // Start is called before the first frame update
    void Start()
    {
         nm = GetComponent<NavMeshAgent>();
         StartCoroutine(Think());
         target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Think()
    {
        while(true)
        {
            switch (aiState)
            {
                case AIState.idle:
                    float dist = Vector3.Distance(target.position , transform.position);
                        if(dist < distancethreshold)
                        {
                        aiState = AIState.chasing;
                        zombiemovement.SetBool("isChasing" , true);
                        }
                        nm.SetDestination(transform.position);
                break;

                case AIState.chasing:
                    dist = Vector3.Distance(target.position , transform.position);
                    if(dist > distancethreshold)
                    {
                        aiState = AIState.idle;
                        zombiemovement.SetBool("isChasing" , false);
                    }
                    if(dist < attackthreshold)
                    {
                        aiState = AIState.attack;
                        zombiemovement.SetBool("isAttacking" , true);
                    }
                    nm.SetDestination(target.position);
                break;

                case AIState.attack:
                
                nm.SetDestination(transform.position);
                   dist = Vector3.Distance(target.position , transform.position);
                   if(dist > attackthreshold)
                   {
                       aiState = AIState.chasing;
                       zombiemovement.SetBool("isAttacking" , false);
                   }

                break;
                    default:
                break;
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
*/