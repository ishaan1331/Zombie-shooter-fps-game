using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldieranimation : MonoBehaviour
{
    public Animator soldieranimator;
public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.UpArrow))
     {
         soldieranimator.SetBool("isRunning" , true);
     }
     if(Input.GetKeyDown(KeyCode.DownArrow))
     {
         soldieranimator.SetBool("isWalkingBack" , true);
         speed = 0.5f;
     }
     if(Input.GetKey(KeyCode.Space))
     {
         soldieranimator.SetBool("isJumping" , true);
     }
     if(Input.GetKeyDown(KeyCode.Mouse0))
     {
         soldieranimator.SetBool("isShooting" , true);
     }
     if(Input.GetKeyUp(KeyCode.UpArrow))
     {
         soldieranimator.SetBool("isRunning" , false);
     }
     if(Input.GetKeyUp(KeyCode.DownArrow))
     {
         soldieranimator.SetBool("isWalkingBack" , false);
         speed = 0.5f;
     }

     
     if(Input.GetKeyUp(KeyCode.Mouse0))
     {
         soldieranimator.SetBool("isShooting" , false);
     }
    }
}
