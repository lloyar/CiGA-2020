using System;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        var mousePosition = Input.mousePosition;
        if (Camera.main == null) return;
        var worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
        var mousePos = new Vector3(worldPoint.x, worldPoint.y, 0);
        var force = mousePos - transform.position;
        _rigidbody2D.velocity = force * 10;
    }

    private void OnMouseUp()
    {
        _rigidbody2D.velocity = Vector2.zero;
    }
}
