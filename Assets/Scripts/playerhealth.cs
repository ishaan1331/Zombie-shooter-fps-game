using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public static playerhealth singleton;
    public float currenthealth;
    public float maxhealth = 100f;
    public bool isDead = false;
    public Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currenthealth < 0)
        {
            currenthealth = 0;
        }
    }

    public void playerdamage(float damage)
    {
        if(currenthealth > 0)
        {
          currenthealth -= damage;
        }
        else
        {
            Dead();
        }
    }

    void Dead()
    {
currenthealth = 0;
isDead = true;
anim.SetBool("isDead" , true);
    }
}
