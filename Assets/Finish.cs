using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            int nextIndex = Mathf.Abs(1 - currentIndex);

            SceneManager.LoadScene(nextIndex);
        }
    }
}
