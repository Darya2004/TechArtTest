using System.Collections;
using UnityEngine;

public class SandsWaves : MonoBehaviour
{
    public TerrainLayer WavesLayer;
    private float scrollSpeed = 2.5F;

    void FixedUpdate()
    {
        float offset = Time.time * scrollSpeed;
        WavesLayer.tileOffset=new Vector2(offset, offset*3);
    }
}
