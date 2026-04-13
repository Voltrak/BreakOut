using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ScriptsCiclosArreglos : MonoBehaviour
{
    public string[] strArreglo1 = { "Yamir", "Lopez", "Farias" };
    public int[] intArreglo2 = { 1, 2, 3, 4, 5 };

    public int contadorFrame = 0;
    public float multiplicadorFijo = 2f; 

    public float numeroDecimal1 = 5.5f;
    public float numeroDecimal2 = 2.4f;
    public int resultadoCasteado; 

     public int contadorColor = 0;

    public string selectorDeColor = "verde"; 

    public float numeroLargo = 3.1415926535f;


    public string miNombreCompleto = "Yamir Lopez Farias"; 

    void Start()
    {
     
        resultadoCasteado = (int)(numeroDecimal1 + numeroDecimal2);
        Debug.Log("Paso 2 - Resultado del casteo: " + resultadoCasteado);

      
        string textoConDecimales = numeroLargo.ToString("F4");
        Debug.Log("Paso 5 - Número con 4 decimales: " + textoConDecimales);


        string nombre = miNombreCompleto.Substring(0, 5); 
 
        string apellido1 = miNombreCompleto.Substring(6, 5); 
       
        string apellido2 = miNombreCompleto.Substring(12, 5); 

        Debug.Log("Paso 6 (Bisturí/Substring): " + nombre + " - " + apellido1 + " - " + apellido2);


        string[] nombreEnLista = miNombreCompleto.Split(' ');

        Debug.Log("Paso 6 (Hacha/Split) Cajón 0: " + nombreEnLista[0]);
        Debug.Log("Paso 6 (Hacha/Split) Cajón 1: " + nombreEnLista[1]);
        Debug.Log("Paso 6 (Hacha/Split) Cajón 2: " + nombreEnLista[2]);
    }

    void Update()
    {
      
        contadorFrame++; 

    
        switch (selectorDeColor)
        {
            case "rojo":
                GetComponent<Renderer>().material.color = Color.red;
                break; 
            case "verde":
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case "azul":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "negro":
                GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }

    void FixedUpdate()
    {
     
        multiplicadorFijo *= 1.1f; 

     
        contadorColor++; 

        if (contadorColor % 2 == 0)
        {
            // GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            // GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}