using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Organik") || other.CompareTag("Non Organik")) 
        {
            Destroy(other.gameObject);
            
        }
    }
}
