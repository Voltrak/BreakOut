using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public Puntajealto PuntajeAltoSO;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("PuntajeAlto"))
       // {
            //PuntajeAltoSO.puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
       // }
        PuntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"Puntaje alto: {PuntajeAltoSO.puntajeAlto}";
        PuntajeAltoSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        PuntajeAltoSO.puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"Puntaje actual: {PuntajeAltoSO.puntaje}";
        if (PuntajeAltoSO.puntaje > PuntajeAltoSO.puntajeAlto)
        {
            PuntajeAltoSO.puntajeAlto = PuntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"Puntaje alto: {PuntajeAltoSO.puntajeAlto}";
            PuntajeAltoSO.Guardian();
            //PlayerPrefs.SetInt("PuntajeAlto", PuntajeAltoSO.puntaje);
        }
    }
}
