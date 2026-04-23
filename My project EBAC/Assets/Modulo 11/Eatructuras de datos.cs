using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called before the first frame update
    void Start()
    {
        //First in First Out => FIFO
        //First in Last Out => FILO
        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0,20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaNumeros.Sort();
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaStrings.Add("Diego");
        listaStrings.Add("Sofia");
        listaStrings.Add("Daniel");
        listaStrings.Add("Javier");
        listaStrings.Add("Diana");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.Remove("Javier");
        listaStrings.Remove("Javier");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        */