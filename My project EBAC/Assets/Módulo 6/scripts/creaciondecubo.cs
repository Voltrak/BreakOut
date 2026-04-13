using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class creaciondecubo: MonoBehaviour
{
    Vector3[] vertices = {
        new Vector3 (0, 0, 0),
        new Vector3 (1, 0, 0),
        new Vector3 (1, 1, 0),
        new Vector3 (0, 1, 0),
        new Vector3 (0, 1, 1),
        new Vector3 (1, 1, 1),
        new Vector3 (1, 0, 1),
        new Vector3 (0, 0, 1),
};
int[] triangulos = {
        0, 2, 1, 
        0, 3, 2,
        2, 3, 4, 
        2, 4, 5,
        1, 2, 5, 
        1, 5, 6,
        0, 7, 4, 
        0, 4, 3,
        5, 4, 7, 
        5, 7, 6,
        0, 6, 7, 
        0, 1, 6
    };
void Start()
{
    GameObject objToSpawn = new GameObject("Nuestro Primer Cubo"); 

    objToSpawn.AddComponent<MeshFilter>();
    var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
    meshFilter.vertices = vertices;
    meshFilter.triangles = triangulos;
    meshFilter.Optimize();
    meshFilter.RecalculateNormals();
    objToSpawn.AddComponent<BoxCollider>();
    BoxCollider BoxCollider = objToSpawn.AddComponent<BoxCollider>();
    BoxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
    objToSpawn.AddComponent<MeshRenderer>();
    var MeshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
    MeshRendererMaterial.color = Color.white;
    objToSpawn.transform.position = Vector3.one;
}

}