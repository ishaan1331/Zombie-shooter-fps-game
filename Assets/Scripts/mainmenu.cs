
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
public void playgame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
}   
public void quit()
{
    Debug.Log("Quit");
    Application.Quit();

}
}
