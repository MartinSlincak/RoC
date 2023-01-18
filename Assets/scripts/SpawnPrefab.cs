using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnPrefab : MonoBehaviour
{
    [SerializeField]
    public Tilemap tileMap;
    public TileBase zasadenyTile;
    public GameObject myPrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(myPrefab, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
            Vector3Int clickedTilePosition = tileMap.WorldToCell(cursorPos);


            tileMap.SetTile(clickedTilePosition, zasadenyTile);
        }


    }
}
