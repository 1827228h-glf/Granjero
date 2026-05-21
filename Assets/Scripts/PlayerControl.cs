using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    public float horizontalInput;
    public float speed = 10.0f;

    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x < -18)
        {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);//izquierda de la pantalla
        }
         if (transform.position.x > 18)
        {
            transform.position = new Vector3(18, transform.position.y, transform.position.z);//derecha de la pantalla
        }

        //Acciones del jugador
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
