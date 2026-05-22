using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] enemigos;
    public int AnimalIndex;

    private float spawnRangeX = 20;

    private float spawnPosZ;

    private float starDelay = 2f;
    private float spawnInterval = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", starDelay, spawnInterval);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (AnimalIndex >= 0 && AnimalIndex < enemigos.Length){
    //        if (Input.GetKeyDown(KeyCode.S))
    //        {
    //             Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    //             AnimalIndex = Random.Range(0, enemigos.Length);
    //             Instantiate(enemigos[AnimalIndex], spawnPos,
    //             enemigos[AnimalIndex].transform.rotation);
    //         }
    //     } 
    //     else {
    //         Debug.Log("El número de enemigo a instanciar no existe");
    //     }
    // }
        private void SpawnRandomAnimal()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                AnimalIndex = Random.Range(0, enemigos.Length);
                Instantiate(enemigos[AnimalIndex], spawnPos,
                enemigos[AnimalIndex].transform.rotation); 
        }
}
