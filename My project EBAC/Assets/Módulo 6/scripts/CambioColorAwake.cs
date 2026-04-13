using UnityEngine;

public class CambioColorAwake : MonoBehaviour
{
    void Awake()
    {
        // Cambia de color 1 sola vez al iniciar, incluso antes del Start
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}
