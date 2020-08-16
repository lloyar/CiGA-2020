using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Congratulate, you win!");
        SceneManager.LoadScene(sceneBuildIndex: 0, LoadSceneMode.Single);
    }
}
