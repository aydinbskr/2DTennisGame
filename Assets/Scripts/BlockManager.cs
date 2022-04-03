using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    
   public Block block;

   Color[] colors = {Color.blue,Color.red,Color.green}; 
   
    private void OnCollisionEnter2D(Collision2D other) {
        print("carpisti");

       

        if(gameObject.name!="special")
        {
            Destroy(gameObject);
        }
        else
        {
            block.hitCount--;

            gameObject.GetComponent<SpriteRenderer>().color=colors[block.hitCount];

            if(block.hitCount==0)
            {
                Destroy(gameObject);
            }
        }
          
    }
}
