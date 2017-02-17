using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof ( MapGenerator))]
public class SphereGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;
        

        if(GUILayout.Button("Generate"))
        {
            mapGen.GenerateSphere();
        }
    }
}

