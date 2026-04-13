using UnityEngine;

public class CambioColorUpdate : MonoBehaviour
{
    void Update()
    {
        // Cambia de color en cada frame (muy rápido)
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}