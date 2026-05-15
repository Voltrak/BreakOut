using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspacioPresionado;

    void Start()
    {
        EnCasoDeEspacioPresionado += EventoEscuchado;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnCasoDeEspacioPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("el evento se escucho correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El Evento Unity se disparo correctamente");
    }
}
