
using UnityEngine;

public class gun : MonoBehaviour
{
    private AudioSource Audiosrc; 
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public float firerate = 15f;
    private float nexttimetofire = 0f;
    public ParticleSystem muzzleflash;
    
    // Start is called before the first frame update
    void Start()
    {
        Audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nexttimetofire  ){
            nexttimetofire = Time.time + 1f/ firerate;
            Shoot();
        }
    }
    void Shoot(){
        muzzleflash.Play();
      Audiosrc.Play();
         RaycastHit hit;
         if(Physics.Raycast(cam.transform.position , cam.transform.forward , out hit , range)){
                   Debug.Log(hit.transform.name);
                   Target target = hit.transform.GetComponent<Target>();
                   if(target != null){
                       target.TakeDamage(damage);
                   }
         }
    }
}
