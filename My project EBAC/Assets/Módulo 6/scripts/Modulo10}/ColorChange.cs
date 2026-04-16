using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}