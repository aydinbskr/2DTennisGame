using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalManager : MonoBehaviour
{
    [SerializeField] float ekranGenisligiUnitCinsinden = 16f;
    [SerializeField] float minX=1.0f;
    [SerializeField] float maxX=15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        float xPosition=Mathf.Clamp(farePozUnitCinsinden,minX,maxX);
        Vector2 pedalPozisyonu = new Vector2(xPosition, transform.position.y);

        transform.position = pedalPozisyonu;
    }
}
