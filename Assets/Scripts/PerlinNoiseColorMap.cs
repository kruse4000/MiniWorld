using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseColorMap
{
    public static Color[] PerlinVertexColoring(Vector3[] verts, float scale, int octaves, float persistance, float lacunarity)
    {
        if(scale <= 0)
        {
            scale = 0.0001f;
        }

        float minNoiseHeight = float.MinValue;
        float maxNoiseHeight = float.MaxValue;


        Color[] colors = new Color[verts.Length];
        for (int i = 0; i < verts.Length; i++)
        {
            float amplitude = 1;
            float frequency = 1;
            float noiseHeight = 0;

            for(int j = 0; j < octaves; j++)
            {
                float sampleX = verts[i].x / scale * frequency;
                float sampleY = verts[i].y / scale * frequency;
                float sampleZ = verts[i].z / scale * frequency;

                float perlinValue = PerlinNoise.Perlin3D(sampleX, sampleY, sampleZ) * 2 - 1;
                noiseHeight += perlinValue * amplitude;

                amplitude *= persistance;
                frequency *= lacunarity;
            }

            if(noiseHeight > maxNoiseHeight)
            {
                maxNoiseHeight = noiseHeight;
            }
            if(noiseHeight < minNoiseHeight)
            {
                minNoiseHeight = noiseHeight;
            }
            Debug.Log(minNoiseHeight);
            Debug.Log(maxNoiseHeight);
            Debug.Log(noiseHeight);
            Debug.Log("XXXXXXXXXXXXXXXXXXXXXXXXX");
            colors[i] = Color.Lerp(Color.black, Color.white, Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, noiseHeight));
        }
        return colors;
    }

}
