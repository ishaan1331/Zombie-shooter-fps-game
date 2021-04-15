  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldiercamera : MonoBehaviour
{
    public float sensitivity;
    public Transform character;
    private float rot;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X")*sensitivity*Time.deltaTime;
         float y = Input.GetAxis("Mouse Y")*sensitivity*Time.deltaTime;
         rot -= y;
         rot = Mathf.Clamp(rot , -90f , 90f);
         transform.localRotation = Quaternion.Euler(rot , 0f , 0f);
         character.Rotate(Vector3.up*x);
    }
}
