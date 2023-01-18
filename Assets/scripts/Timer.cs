using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Tilemaps;


public class Timer : MonoBehaviour
{

    private float timeToGrow = 10;
    public TileBase tileA;
    public TileBase tileB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToGrow > 0 )
        {
            timeToGrow -= Time.deltaTime;
            
        }
        else if (timeToGrow < 0)
        {
            Tilemap tilemap = GetComponent<Tilemap>();
            tilemap.SwapTile(tileA, tileB);
            timeToGrow = 10;
        }
    }
}
