using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block 
{
    public int hitCount;
    public Color color;

    public abstract Color getColor();
  
}
