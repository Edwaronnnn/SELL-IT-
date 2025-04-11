using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public string correctTag; // Tag yang sesuai untuk sampah yang benar
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(correctTag))
        {
            Debug.Log("Benar! Produk masuk ke tempat yang benar.");
            GameManager.instance.AddScore(10); // Tambah skor
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("Salah! Produk masuk ke tempat yang salah.");
            GameManager.instance.ReduceScore(5); // Kurangi skor
        }
    }

}
