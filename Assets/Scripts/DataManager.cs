using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;
public class DataManager : MonoBehaviour
{
     EasyFileSave myFile;
    public static DataManager Instance;
    
    private int userScore;

    public string username="";

    List<string> oldScores2=new List<string>();

    public GameObject playerMenu;

     
    void Awake()
    {
        if(Instance==null)
        {
            Instance=this;
            myFile=new EasyFileSave();
            playerMenu.SetActive(true);
            
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Start()
    {
         GameObject.Find("player").GetComponent<Text>().text=username+"'s game";
    }

    public int UserScore
    {
        get
        {
            return userScore;
        }
        set
        {
            userScore=value;
        }
    }

    public void GetUsername()
    {
        username=GameObject.Find("InputField").GetComponent<InputField>().text;
        GameObject.Find("player").GetComponent<Text>().text=username+"'s game";
        GameObject.Find("playerMenu").SetActive(false);

    }
   
     public void SetScore()
    {
       GameObject.Find("Score").GetComponent<Text>().text=username+"'s Score:"+userScore.ToString();

    }

     public void SaveData()
    {
        if(myFile.Load())
        {
            oldScores2=myFile.GetList<string>("scores");
        }
        oldScores2.Add(username+" "+userScore);
        myFile.Add("scores",oldScores2);
        myFile.Save();
    }
     public void LoadData()
    {
        if(myFile.Load())
        {
            oldScores2=myFile.GetList<string>("scores");

            oldScores2.Reverse();

            string scores="Scores\n";

            int counter=1;

            foreach(string item in oldScores2)
            {
                scores+=item.ToString()+"\n";

                if(counter==5)
                {
                    break;
                }
                counter++;
            }
            GameObject.Find("Scores").GetComponent<Text>().text=scores;
           
        }
        
    }

    
}
