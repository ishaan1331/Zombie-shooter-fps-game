using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawn : MonoBehaviour
{
    public GameObject zombie;
    float xpos;
    float ypos;
    float zpos;
    public int noofzombies = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }
    IEnumerator Enemyspawn(){
        for (int i = 0; i < noofzombies; i++)
        {
            xpos = Random.Range(-40f , 60f);
            ypos = Random.Range(3f, 10f);
            zpos = Random.Range(-50f , 0f);
            Instantiate(zombie , new Vector3(xpos , ypos , zpos) , Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
