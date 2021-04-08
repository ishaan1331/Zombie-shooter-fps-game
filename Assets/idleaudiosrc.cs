using System.Reflection;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleaudiosrc : MonoBehaviour
{public AudioSource idlezombie;
int deadones;
int aliveones;
int total;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deadones = Target.dead;
        aliveones = enemyspawn.kitneaadmithe - deadones;
        if(aliveones < deadones){
            idlezombie.Play();
        }
    }
}
