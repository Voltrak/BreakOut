using UnityEngine;

public class CambioColorFixed : MonoBehaviour
{
    void FixedUpdate()
    {
        // Cambia de color 50 veces por segundo (ritmo constante)
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}