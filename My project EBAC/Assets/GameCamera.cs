using UnityEngine;

public class GameCamera : MonoBehaviour
{
    // La variable para saber a quién mirar (Tu cubo)
    public Transform target;
    
    // La distancia a la que queremos estar (puedes ajustarlo en Unity)
    public Vector3 offset = new Vector3(2, 3, -5);

    void LateUpdate()
    {
        // Si hay un objetivo asignado...
        if (target != null)
        {
            // 1. Nos movemos a la posición del objetivo + la distancia
            transform.position = target.position + offset;
            
            // 2. Giramos la cámara para mirar al centro del objetivo
            transform.LookAt(target);
        }
    }
}