using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    private float topSup = 21.0f;
    private float topInf = -20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topSup)
        {
            Destroy(gameObject);
        }
        if (this.transform.position.z < topInf)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);

            Time.timeScale = 0;
        }
    }
}
