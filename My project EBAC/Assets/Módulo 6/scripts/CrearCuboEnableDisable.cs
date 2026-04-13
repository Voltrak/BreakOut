using UnityEngine;

public class CrearCuboEnableDisable : MonoBehaviour
{
    public GameObject objetoParaClonar; // Tu Prefab va aquí

    void OnEnable()
    {
        // Se crea al activar el objeto
        GameObject nuevoObjeto = Instantiate(objetoParaClonar, new Vector3(2, 1, 0), Quaternion.identity);
        nuevoObjeto.name = "Objeto_OnEnable"; // Le ponemos nombre para distinguirlo
    }

    void OnDisable()
    {
        // Se crea al desactivar el objeto
        GameObject nuevoObjeto = Instantiate(objetoParaClonar, new Vector3(-2, 1, 0), Quaternion.identity);
        nuevoObjeto.name = "Objeto_OnDisable";
    }
}