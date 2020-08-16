using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShotAim : MonoBehaviour
{
    public Transform Bullet;
    public GameObject BulletFlag;
    private bool _enter;
    public int SceneId;
    public AudioSource Source;

    // Update is called once per frame
    void Update()
    {
        var mouseButtonDown0 = Input.GetMouseButtonDown(0);
        if (!mouseButtonDown0) return;
        Instantiate(BulletFlag, Bullet.transform.position, quaternion.identity);
        Source.Play();
        if (_enter)
        {
            Debug.Log("Congratulation, you win!");
            SceneManager.LoadScene(sceneBuildIndex: SceneId, LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _enter = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _enter = false;
    }
}