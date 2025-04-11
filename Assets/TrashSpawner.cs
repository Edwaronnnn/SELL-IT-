using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject[] trashPrefabs; // Array untuk jenis sampah
    public float spawnInterval = 2f;  // Waktu antar spawn
    public Transform spawnPoint;      // Posisi spawn sampah

    void Start()
    {
        InvokeRepeating(nameof(SpawnTrash), 1f, spawnInterval);
    }

    void SpawnTrash()
    {
        if (trashPrefabs.Length == 0) return;

        // Pilih sampah acak dari array
        int index = Random.Range(0, trashPrefabs.Length);
        GameObject trash = Instantiate(trashPrefabs[index], spawnPoint.position, Quaternion.identity);

        // Pastikan sampah memiliki Rigidbody2D
        Rigidbody2D rb = trash.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = new Vector2(0, 0); // Awalnya diam, nanti didorong conveyor
        }
    }
}
