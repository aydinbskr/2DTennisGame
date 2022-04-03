using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
   
    
    public BlockFactory blockFactory;

    public string currentScene;

    public GameObject winner;

    public int levelUpScore;
    void Start()
    {
        //scoreText.text="Score:"+score;
        DataManager.Instance.SetScore();

        currentScene=SceneManager.GetActiveScene().name;
       
        if(currentScene=="Level1")
        {
            levelUpScore=20;
            Block  block=new Level1Block(2,Color.magenta);
            blockFactory.createBlock(block);
        }
        else
        {
            Block  block=new Level1Block(3,Color.black);
            levelUpScore=41;
            blockFactory.createBlock(block);
        }
           
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int points)
    {
        //score+=points;
        //scoreText.text="Score:"+score;
        DataManager.Instance.UserScore+=points;

        DataManager.Instance.SetScore();

        if(DataManager.Instance.UserScore==levelUpScore && currentScene=="Level1")
        {
            
            SceneManager.LoadScene("Level2");
  
        }
        else if(DataManager.Instance.UserScore==levelUpScore && currentScene=="Level2")
        {

            winner.SetActive(true);

            GameObject.Find("Title").GetComponent<Text>().text="Winner";
            DataManager.Instance.SaveData();
            DataManager.Instance.LoadData();
            

        }
    }
   

    
}
