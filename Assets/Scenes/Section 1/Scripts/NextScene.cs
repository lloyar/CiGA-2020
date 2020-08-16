using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void ActiveNextScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
