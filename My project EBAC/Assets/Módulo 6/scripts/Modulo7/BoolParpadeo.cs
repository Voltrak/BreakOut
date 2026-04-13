using UnityEngine;

public class BoolParpadeo : MonoBehaviour
{
    // Esta es la variable que el profe pide (el interruptor)
    public bool variableBooleana = false;

    // Usamos FixedUpdate porque lo pide la instrucción 4
    void FixedUpdate()
    {
        // Esta línea invierte el valor: Si es true se vuelve false, y al revés.
        variableBooleana = !variableBooleana;

        // Si es VERDADERO -> Blanco. Si es FALSO -> Negro.
        if (variableBooleana == true)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}