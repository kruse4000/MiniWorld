using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDeformer : MonoBehaviour {

	public static Vector3[] SimpleDistort(Vector3[] verts, float radiusVariation)
    {
        List<Vector3> changedVerts = new List<Vector3>();
        foreach (Vector3 vert in verts)
        {
            Vector3 displacedVert = vert * ((PerlinNoise.Perlin3D(vert.x, vert.y, vert.z) + (radiusVariation - 1)) / radiusVariation);
            changedVerts.Add(displacedVert);
        }
        return changedVerts.ToArray();
    }


}
