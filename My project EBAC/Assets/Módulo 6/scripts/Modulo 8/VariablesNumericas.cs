using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
        public string textoMiles1 = "4000";
    public string textoMiles2 = "2500";

       public string oracionMagica = "Hola Mundo";

        public string oracionLarga = "Murciélago es una palabra genial";

    void Start()
    {
        int numeroReal1;
        int numeroReal2;
        int.TryParse(textoMiles1, out numeroReal1);
        int.TryParse(textoMiles2, out numeroReal2);
        int resultadoSuma = numeroReal1 + numeroReal2;
        Debug.Log("Paso 1 - La suma matemática es: " + resultadoSuma);

        string letrasPares = "";
        for (int i = 0; i < oracionMagica.Length; i++)
        {
            if (i % 2 == 0)
            {
                letrasPares += oracionMagica[i] + ",";
            }
        }
        Debug.Log("Paso 2 - Letras en posición par: " + letrasPares);

 
        string oracionRecortada = oracionLarga.Substring(5);
        
        Debug.Log("Paso 3 - Oración sin las primeras 5 letras: " + oracionRecortada);
    }
}