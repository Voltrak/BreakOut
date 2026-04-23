using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            lista.Add(Random.Range(rangoInferior, rangoSuperior));
        }
        return lista;
    }

    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] copia = (int[])arreglo.Clone();
        System.Array.Sort(copia);
        System.Array.Reverse(copia);
        return copia;
    }

    public HashSet<T> EliminarDuplicados<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    public void ProcesarPilaYCola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();
        
        // Imprimir contenidos de la pila y copiar a la cola
        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log("Pila: " + elemento);
            cola.Enqueue(elemento);
            pila.Pop();
        }
        
        // Imprimir elementos de la cola
        while (cola.Count > 0)
        {
            string elemento = cola.Peek();
            Debug.Log("Cola: " + elemento);
            cola.Dequeue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
