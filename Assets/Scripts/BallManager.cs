using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    public GameObject gamePedal;
    bool gameStarted=false;
    Vector2 differance;
    private AudioSource sound;
     public AudioClip[] voiceovers;

    
    public GameManager gameManager;
    
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        differance=this.transform.position-gamePedal.transform.position;
        sound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowBallPedal(); 
        ThrowBall();
        
    }
    void FollowBallPedal()
    {
        if (gameStarted==false)
        {
            Vector2 pedalPosition = new Vector2(gamePedal.transform.position.x ,
                                            gamePedal.transform.position.y);
            transform.position=pedalPosition+differance;
        }
        
    }
     void ThrowBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("mouse tıklandı");
            gameStarted=true;
            //GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 12f);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*speed);

        }
    }
   
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.CompareTag("tile"))
        {
            sound.PlayOneShot(voiceovers[0]);
            gameManager.UpdateScore(1);
            if(DataManager.Instance.UserScore==gameManager.levelUpScore)
            {
                GetComponent<Rigidbody2D>().velocity=Vector2.zero;
            }
            
        }
        else if(other.collider.tag =="wall")
        {
            sound.PlayOneShot(voiceovers[1]);
        }
        
    }

}
