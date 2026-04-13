using UnityEngine;

public class CrearCubosUpdate : MonoBehaviour
{
    void Update()
    {
       GameObject.CreatePrimitive(PrimitiveType.Cube);
      
       GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
       cubo.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(5, 10), 0);
        
       cubo.AddComponent<Rigidbody>();
    }
}
