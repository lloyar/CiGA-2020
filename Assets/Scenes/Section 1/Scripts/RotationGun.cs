using UnityEngine;

public class RotationGun : MonoBehaviour
{
    public Transform Bullet;

    private Vector3 _initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = Bullet.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var curPosition = Bullet.position - transform.position;
        var angle = Vector3.SignedAngle(_initialPosition, curPosition,Vector3.forward);

        transform.localRotation = Quaternion.Euler(0,0,angle);
    }
}
