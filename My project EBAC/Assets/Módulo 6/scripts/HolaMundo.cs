using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    // Se llama antes del primer frame
    void Start()
    {
        x = 0;
        print("Algo pasó");

        Debug.LogWarning("Algo salió medianamente mal");
        Debug.LogError("Algo salió muy mal");
    }

    // Se llama una vez por frame
    void Update()
    {
        x = x + 1;
        Debug.Log("Valor de x: " + x);
    }

    // Otra función del ciclo de Unity
    void Awake()
    {
        Debug.Log("Awake: El objeto HolaMundo se está inicializando");
    }
}