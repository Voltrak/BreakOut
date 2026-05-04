using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public float VelocidadPaddle = 0.5f;
    new Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    float leftLimit;
    float rightLimit;

    // Start is called once before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
        
        // Configurar el Rigidbody para que no sea movido por nada
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        
        // Calcular los límites basados en el viewport de la cámara
        float distance = Mathf.Abs(Camera.main.transform.position.z - transform.position.z);
        leftLimit = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x;
        rightLimit = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x;
        
        // Si el paddle tiene ancho, ajustar los límites
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            float halfWidth = spriteRenderer.bounds.extents.x;
            leftLimit += halfWidth;
            rightLimit -= halfWidth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        //}

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * VelocidadPaddle * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, leftLimit, rightLimit);
        transform.position = pos;
    }
}
