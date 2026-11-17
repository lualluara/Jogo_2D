using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarFase : MonoBehaviour
{
    public string Fase2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Fase2);
        }
    }
}
