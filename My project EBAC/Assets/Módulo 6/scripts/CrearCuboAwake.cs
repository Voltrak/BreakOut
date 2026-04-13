using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    // 1. Variable para meter tu Prefab (el cubo o esfera que ya tienes)
    public GameObject objetoParaClonar;

    void Awake()
    {
        // 2. Usamos Instantiate en lugar de CreatePrimitive
        // Esto crea una copia exacta de tu Prefab en la posición (0, 2, 0)
        Instantiate(objetoParaClonar, new Vector3(0, 2, 0), Quaternion.identity);
    }
}