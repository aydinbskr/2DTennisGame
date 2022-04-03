using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosingCollider : MonoBehaviour
{
    public GameObject GameOver;
    private void OnTriggerEnter2D(Collider2D other) {
        print("Game over");
        
       GameOver.SetActive(true);
       DataManager.Instance.SaveData();
       DataManager.Instance.LoadData();

       if(SceneManager.GetActiveScene().name=="Level1")
       {
           DataManager.Instance.UserScore=0;
       }
       else
       {
           DataManager.Instance.UserScore=20;
       }
       
    }
}
