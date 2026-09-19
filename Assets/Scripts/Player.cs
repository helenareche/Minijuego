using UnityEngine;

public class Player : MonoBehaviour
{
    //Parametros para la velocidad del objeto
    //Un atributo con public permite editar su valor dentor de la escena en Unity
    public float thrustForce = 10f; //fuerza de empuje
    public float rotationSpeed = 120f; //velocidad de rotación
    
    private Rigidbody _rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Para la configuracion inicial del objeto
        _rigid = GetComponent<Rigidbody>(); //inicializamos el objeto
    }

    // Update is called once per frame
    void Update()
    {
        //Se ejecuta al final de cada frame del juego
       float thrust = Input.GetAxis("Vertical") * Time.deltaTime;   //deteccion del movimiento cuando el usuario juega
       float rotation = Input.GetAxis("Horizontal") * Time.deltaTime; 
       Vector3 thrustDirection = transform.right; //porque la cabeza de la nave apunta a la derecha

       _rigid.AddForce(thrustDirection * thrust * thrustForce);
       transform.Rotate(Vector3.forward, -rotation * rotationSpeed);
    }
}
