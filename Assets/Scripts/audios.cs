using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audios : MonoBehaviour
{
   // public AudioSource idlezom;
    public AudioSource attackzom;
    public AudioSource chasezom;
    public Animator zomanim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(zomanim.GetBool("isChasing"))
        {
            chasezom.Play();
        }
        if(zomanim.GetBool("isAttacking"))
        {
            attackzom.Play();
        }
    }
}
