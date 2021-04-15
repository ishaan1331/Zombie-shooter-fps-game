using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public CharacterController cc;
    public AudioSource acc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cc.isGrounded == true && cc.velocity.magnitude > 0f && acc.isPlaying == false)
        {
            acc.volume = Random.Range(0f , 1f);
            acc.pitch = Random.Range(0.8f , 1.1f);
            acc.Play();
        }
    }
}
