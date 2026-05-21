using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] enemigos;
    public int AnimalIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimalIndex >= 0 && AnimalIndex < enemigos.Length){
           if (Input.GetKeyDown(KeyCode.S)){
                Instantiate(enemigos[AnimalIndex], new Vector3 (0,0,transform.position.z),
                enemigos[AnimalIndex].transform.rotation);
            }
        } 
        else {
            Debug.Log("El número de enemigo a instanciar no existe");
        }
    }
}
