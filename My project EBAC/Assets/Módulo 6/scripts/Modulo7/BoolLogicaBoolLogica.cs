using UnityEngine;

public class BoolLogica : MonoBehaviour
{
    // Aquí conectaremos al Cubo y la Esfera para ver sus valores
    public BoolParpadeo scriptObjeto1;
    public BoolParpadeo scriptObjeto2;

    // Casilla para elegir: ¿Queremos que funcione con AND o con OR?
    public bool usarLogicaAND = true; 

    void FixedUpdate()
    {
        // 1. "Robamos" el valor actual de los otros dos objetos
        bool valor1 = scriptObjeto1.variableBooleana;
        bool valor2 = scriptObjeto2.variableBooleana;

        bool resultadoFinal = false;

        // 2. Aplicamos la lógica (Puntos 7 y 8 de la tarea)
        if (usarLogicaAND == true)
        {
            // AND (&&): Solo es verdad si LOS DOS son verdad al mismo tiempo
            resultadoFinal = valor1 && valor2;
        }
        else
        {
            // OR (||): Es verdad si CUALQUIERA de los dos es verdad
            resultadoFinal = valor1 || valor2;
        }

        // 3. Nos pintamos según el resultado
        if (resultadoFinal == true)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}