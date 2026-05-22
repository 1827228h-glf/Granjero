using UnityEngine;

public class CheckColliders : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
        
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
}
