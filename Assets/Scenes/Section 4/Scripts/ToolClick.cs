using UnityEngine;

public class ToolClick : MonoBehaviour
{
    public GameObject Aim;
    private bool _clicked;

    // Update is called once per frame
    void Update()
    {
        if (!_clicked) return;
        var mousePosition = Input.mousePosition;
        if (Camera.main == null) return;
        var worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldPoint.x, worldPoint.y, 0);
    }

    private void OnMouseDown()
    {
        _clicked = true;
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        GetComponent<Collider2D>().enabled = false;
        Aim.gameObject.SetActive(true);
    }
}