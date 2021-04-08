using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class killcount : MonoBehaviour
{ 
    public int deadzombie ;
    public TMP_Text deadtext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deadzombie = Target.dead;
        deadtext.text = deadzombie.ToString();
    }
}
