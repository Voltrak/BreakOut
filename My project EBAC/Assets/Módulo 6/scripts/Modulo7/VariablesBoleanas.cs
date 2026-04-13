using UnityEditor.Rendering;
using UnityEngine;

public class VariablesBoleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if(variable1 == true)
        {
            Debug.Log("esta variable es verdadera");
            Debug.Log("ya tienes el valor de la variable 1");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
