using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonespawn : MonoBehaviour
{
    public GameObject extraprop;
    float xpos;
    float ypos;
    float zpos;
    public int noofbones = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(haddispawn());
    }
    IEnumerator haddispawn(){
        for (int i = 0; i < noofbones; i++)
        {
            xpos = Random.Range(-40f , 60f);
            ypos = Random.Range(3f, 10f);
            zpos = Random.Range(-50f , 0f);
            Instantiate(extraprop , new Vector3(xpos , ypos , zpos) , Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }
    }

