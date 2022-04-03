using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFactory : MonoBehaviour
{
    public GameObject go;
    public GameObject createBlock(Block  block)
    {
      
         
        

        Vector3 pos= new Vector3(Random.Range(3,5),3,0);

        

        GameObject newBlock= Instantiate(go,gameObject.transform);
        newBlock.GetComponent<SpriteRenderer>().color=block.getColor();
        newBlock.GetComponent<BlockManager>().block=block;
        newBlock.name="special";
        return newBlock;
       
    }
}
