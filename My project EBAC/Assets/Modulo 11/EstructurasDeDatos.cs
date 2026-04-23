using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called once before the first frame update
    void Start()
    {
        //First in Last Out => FILO
        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        if (pilaStrings.Count > 0)
        {
            Debug.Log(pilaStrings.Peek());
            pilaStrings.Pop();
        }
        if (pilaStrings.Count > 0)
        {
            Debug.Log(pilaStrings.Peek());
            pilaStrings.Pop();
        }

        DemoDictionary("escopeta");
        DemoDictionary("espada");
    }

    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }

        if (poderArmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
