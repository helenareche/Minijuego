using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; //velocidad de la bala
    public float maxLifeTime = 3f; //tiempo de vida de la bala
    public Vector3 targetVector; //direccion bala

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, maxLifeTime); //funcion para destruir la bala
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * targetVector * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
