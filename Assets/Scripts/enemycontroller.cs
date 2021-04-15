
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{ 
    NavMeshAgent nm;
    public Transform target;
    float turnspeed = 5f;
    public enum AIState {idle , chasing , attack};
    public AIState aiState = AIState.idle;
    public float distancethreshold = 10f;
    public Animator zombiemovement;
    public float attackthreshold = 2f;
    public float damageamount = 30f;
    public float attacktime = 1f;
    public bool canattack = true;
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
                nm.updateRotation = true;
                nm.updatePosition = true;
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
                
                 if(canattack && !playerhealth.singleton.isDead)
                {
                     nm.updateRotation = false;
                Vector3 direction = target.position - transform.position;
                direction.y = 0;
                transform.rotation = Quaternion.Slerp(transform.rotation , Quaternion.LookRotation(direction) , turnspeed * Time.deltaTime);
                nm.SetDestination(transform.position);
                   dist = Vector3.Distance(target.position , transform.position);
                   if(dist > attackthreshold)
                   {
                       aiState = AIState.chasing;
                       zombiemovement.SetBool("isAttacking" , false);
                       StartCoroutine(Attacktime());
                   }
                   IEnumerator Attacktime()
                {
                    canattack = false;
                    yield return new WaitForSeconds(0.2f);
                    playerhealth.singleton.playerdamage(damageamount);
                    yield return new WaitForSeconds(attacktime);
                canattack = true;
                }
                }
                else if(playerhealth.singleton.isDead)
                {
                    disableenemy();
                }
                break;  
                void disableenemy()
                {
                    canattack = false;
                    zombiemovement.SetBool("isAttacking" , false);
                    zombiemovement.SetBool("isChasing" , false);
                   
                } 
                  
                default:
                break;
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
