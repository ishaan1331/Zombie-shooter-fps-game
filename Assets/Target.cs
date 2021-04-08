using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Target : MonoBehaviour
{

  NavMeshAgent nm ;
  public Animator anim;
 public float health = 50f; 
public static int dead = 0;

 public void TakeDamage(float amount){
     Back();
     health -= amount;
     if(health<=0f){
         Die();
         
     }  
 }

 
 void Die(){
     
   
     anim.SetBool("DeadZombie" , true);
  Destroy(gameObject , 1);
    dead += 1;
    
    // nm.Stop();

     
       //GameObject varGameObject = GameObject.Find("zombiecontrol");
     //varGameObject.GetComponent<zombiecontrol>().enabled = false;
 
 }

void Back(){
    anim.SetBool("ZombieAttacked" , true);

}}
   

 

