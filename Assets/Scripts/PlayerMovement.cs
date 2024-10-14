using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private Camera cam;
    private Rigidbody2D rb;
    private Vector3 worldPos;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        cam = Camera.main;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        worldPos =cam.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
    }

    void FixedUpdate()
    {
        var targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);
        rb.MovePosition(targetPos);
    }
}
