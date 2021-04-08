using System.Net.Mime;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;
public class helth : MonoBehaviour
{
     public static  helth singleton;
     public float currenthealth;
     public float maxhealth = 100f;
    public Slider slider;
    public TMP_Text healthtext;
    public Animator soldieranimation;

    private void Awake(){
        singleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = currenthealth;
        healthtext.text = currenthealth.ToString();
    }
  
    public void DamagePlayer(float damage){
        if(currenthealth > 0){
currenthealth -= damage;
        }
        
    }
    
}
