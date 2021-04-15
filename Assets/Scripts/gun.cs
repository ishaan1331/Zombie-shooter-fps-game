 using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float firerate = 15f;
    public Camera cam;
    public ParticleSystem muzzleflash;
    public Animator anim;
    private float nexttimetofire = 0f;
    public AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Mouse0) && Time.time >= nexttimetofire)
        {muzzleflash.Play();src.Play();
            nexttimetofire = Time.time + 1f/firerate;
            
            Shoot();
        }
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
           anim.SetBool("isShooting" , false); 
        }
    }
    void Shoot()
    {
        anim.SetBool("isShooting" , true);
        muzzleflash.Play();
        src.Play();
                RaycastHit hit;
        if(Physics.Raycast(cam.transform.position , cam.transform.forward , out hit , range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        
        }
        
    }
}
