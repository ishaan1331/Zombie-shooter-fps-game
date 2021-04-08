
using System.ComponentModel;
using System;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombiecontrol : MonoBehaviour
{
  public AudioSource isidle;
public AudioSource ischasing;
public AudioSource isattacked;
    NavMeshAgent nm ;
    public Transform target;
    public enum AIState {idle , chasing};
    public AIState aistate = AIState.idle;
    public Animator animator;
    public float damageamt = 40f;
    [SerializeField]
    float attacktime = 2f;
    // Start is called before the first frame update
    void Start()
    {
      nm = GetComponent<NavMeshAgent>();
      StartCoroutine(Think());
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Think(){
      while(true){
        switch(aistate){
          case AIState.idle:
          
          float dist = Vector3.Distance(target.position , transform.position);
          if (dist < 30f)
          {
            aistate = AIState.chasing;
            animator.SetBool("Chasing" , true);
          }
          nm.SetDestination(transform.position);
          break;
          case AIState.chasing:
          ischasing.Play();
          dist = Vector3.Distance(target.position , transform.position);
          if (dist > 30f)
          {
            aistate = AIState.idle;
            animator.SetBool("Chasing" , false);
          }
          nm.SetDestination(target.position);
          break;
          
          default :
          break;
        }
        if(animator.GetBool("ZombieAttacked")){
          isattacked.Play();
          float dist = Vector3.Distance(target.position , transform.position);
          if (dist < 30f && dist > 3f)
          {
            ischasing.Play();
            aistate = AIState.chasing;
            yield return new WaitForSeconds(2.167f);
            animator.SetBool("Chasing" , true);
               animator.SetBool("ZombieAttacked" , false);
               
          } /*
          else if(dist < 3f){

            void OnCollisionEnter(Collision other){
              if(other.gameObject.tag == "Enemy"){
              ischasing.Play();
            aistate = AIState.chasing;
            yield return new WaitForSeconds(2.167f);
            animator.SetBool("Chasing" , true);
               animator.SetBool("ZombieAttacked" , false);
              yield return new WaitForSeconds(0.5f);
              helth.singleton.DamagePlayer(damageamt);
              yield return new WaitForSeconds(2f);
               }
              
            }
            
          }*/
          else 
           if(dist > 30f)
          {
            isidle.Play();
            aistate = AIState.idle;
            yield return new WaitForSeconds(2.167f);
            animator.SetBool("Chasing" , false);
             animator.SetBool("ZombieAttacked" , false);
            
          }
        yield return new WaitForSeconds(0.2f);
            }}
    }}

