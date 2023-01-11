using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolscharactercontroller : MonoBehaviour
{
    [SerializeField] MarkerManager markerManager;
    [SerializeField] TileMapReadController tileMapReadController;



    
    private void Marker()
    {
        Vector3Int gridPosition = tileMapReadController.GetGridPosition(Input.mousePosition, true);
        markerManager.markedCellPosition = gridPosition;
    }
}
