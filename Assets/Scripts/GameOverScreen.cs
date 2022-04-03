using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
        DataManager.Instance.UserScore=0;

        
    }
    public void RePlay()
    {
       if(SceneManager.GetActiveScene().name=="Level1")
       {
           DataManager.Instance.UserScore=0;
       }
       else
       {
           DataManager.Instance.UserScore=20;
       }
       gameObject.SetActive(false);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
