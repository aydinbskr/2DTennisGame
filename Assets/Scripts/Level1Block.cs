using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Block : Block
{
   public Level1Block(int hitCount, Color c ){
       this.hitCount=hitCount;
       this.color=c;
   }

   
    public override Color getColor()
    {
        return this.color;
    }
}
