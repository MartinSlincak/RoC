using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileChanger : MonoBehaviour
{
    public TileBase zasadenyTile;

    [SerializeField]
    public Tilemap tileMap;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int clickedTilePosition = tileMap.WorldToCell(mousePosition);


            tileMap.SetTile(clickedTilePosition, zasadenyTile);

        }

    }


}
