using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Generating : MonoBehaviour
{
    public GameObject Tile;
    public int Lenght;
    public int Width;
    void Start()
    {
        for (float x = 0.5f; x < Width; x++)
        {
            for (float y = 0.5f; y < Lenght; y++)
            {
                Instantiate(Tile.transform, new Vector3(x,0,y), Quaternion.identity, transform.parent);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
