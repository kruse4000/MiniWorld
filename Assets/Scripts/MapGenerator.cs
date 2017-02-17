using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public int sphereRadius;
    public float noiseScale;
    public int recursionLevel;
    public float radiusVariation;
    public bool autoUpdate;

    public float persistance;
    public float lacunarity;
    public int octaves;

    public void GenerateSphere()
    {                
        Mesh mesh = CreateIcoSphere.CreateMySphere(recursionLevel, sphereRadius);
        Selection.activeObject = mesh;
    }

}
