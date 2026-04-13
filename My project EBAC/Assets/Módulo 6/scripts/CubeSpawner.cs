using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject>listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    void Update()
    {
        numCubos ++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = UnityEngine.Random.insideUnitSphere;

        listaDeCubos.Add(tempGameObject);
        List<GameObject>objetosParaEliminar = new List<GameObject>();
        foreach(GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = new Vector3(scale, scale, scale);

            if (scale < 0.1f)
            {
                objetosParaEliminar.Add(go);
            }
        }
        foreach(GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
