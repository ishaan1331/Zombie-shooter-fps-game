
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{   public GameObject dushman;
     int xpos;
    int zpos;
    int ypos;
    public static int kitneaadmithe = 40;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop(){
        for (int i = 0; i < kitneaadmithe ; i++)
        {
            xpos = Random.Range(-25,90);
            ypos = Random.Range(-16,-21);
            zpos = Random.Range(5,60);
            Instantiate(dushman , new Vector3(xpos,0,zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.25f);
        }


        }

          
}
