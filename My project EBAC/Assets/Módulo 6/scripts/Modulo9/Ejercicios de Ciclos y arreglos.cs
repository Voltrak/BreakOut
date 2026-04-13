using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    // ==========================================
    // VARIABLES PASO 1
    // ==========================================
    public int[] arreglo1 = new int[5];
    public int[] arreglo2 = new int[5];
    public int[] arregloSuma = new int[5];

    // ==========================================
    // VARIABLES PASO 2
    // ==========================================
    public string[] palabras = { "Hacer", "juegos", "en", "Unity", "es", "genial" };

    // ==========================================
    // VARIABLES PASO 3: MATRIZ Y VECTORES
    // ==========================================
    // Matriz de 2 renglones y 3 columnas (2x3)
    public int[,] matriz = new int[2, 3] { 
        { 1, 2, 3 }, 
        { 4, 5, 6 } 
    };
    
    // Vector de 3 elementos (para que coincida con las columnas)
    public int[] vector = new int[3] { 2, 3, 4 };
    
    // Vector final donde guardaremos los 2 resultados
    public int[] vectorResultado = new int[2];

    void Start()
    {
        // ==========================================
        // PASO 1: SUMA DE ARREGLOS CON RANDOM
        // ==========================================
        Debug.Log("--- RESULTADOS PASO 1 ---");
        for (int i = 0; i < arreglo1.Length; i++)
        {
            arreglo1[i] = Random.Range(1, 11);
            arreglo2[i] = Random.Range(1, 11);
            arregloSuma[i] = arreglo1[i] + arreglo2[i];
            Debug.Log("Cajón " + i + ": " + arreglo1[i] + " + " + arreglo2[i] + " = " + arregloSuma[i]);
        }

        // ==========================================
        // PASO 2: FOREACH Y CONCATENACIÓN
        // ==========================================
        Debug.Log("--- RESULTADOS PASO 2 ---");
        string oracionCompleta = "";
        foreach (string palabraSuelta in palabras)
        {
            oracionCompleta += palabraSuelta + " ";
        }
        Debug.Log("La oración unida es: " + oracionCompleta);

        // ==========================================
        // PASO 3: MULTIPLICACIÓN MATRIZ * VECTOR
        // ==========================================
        Debug.Log("--- RESULTADOS PASO 3 ---");
        
        // 1. Ciclo exterior: Recorre los 2 renglones de la matriz (i)
        // GetLength(0) nos da la cantidad de renglones
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int sumaTemporal = 0; // Aquí iremos acumulando la suma de la fórmula
            
            // 2. Ciclo interior: Recorre las 3 columnas y el vector (j)
            // GetLength(1) nos da la cantidad de columnas
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Fórmula: a_i1*b_1 + a_i2*b_2 + a_i3*b_3 ...
                sumaTemporal += matriz[i, j] * vector[j];
            }
            
            // 3. Guardamos el resultado aplastado en nuestro arreglo final
            vectorResultado[i] = sumaTemporal;
            Debug.Log("El resultado matemático del renglón " + i + " es: " + vectorResultado[i]);
        }
    }
}