using System.IO.Compression;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  public float health = 50f;
  public Animator zom;
  public static int dead = 0;
void Start()
{
    StartCoroutine(Attacked());
}

   
  public void TakeDamage(float amount)
  {
      //zom.SetBool("isAttacked" , true);
      //zom.SetBool("isChasing" , true);
      health -= amount;
      if(health <= 0f)
      {
          Die();
      }
      
  }

   IEnumerator Attacked()
{
    if(zom.GetBool("isAttacked") ==true)
    {
        yield return new WaitForSeconds(2f);
        zom.SetBool("isAttacked" , false);
    }
}



  void Die()
  {
      zom.SetBool("isDead" , true);
      Destroy(gameObject);
      dead += 1;
      //GameObject  varGameObject = GameObject.Find("Target.cs");
      //varGameObject.GetComponent<Target>().enabled = false;
  }
}
