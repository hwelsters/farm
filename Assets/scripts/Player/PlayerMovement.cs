using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float MOVEMENT_SPEED = 4f;

    private Rigidbody2D rb2D;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        HandleInput();
    }

    private void HandleInput() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 moveDir = new Vector2(moveX, moveY);
        moveDir = Vector2.ClampMagnitude(moveDir, 1f);

        Vector2 moveVelocity = moveDir * MOVEMENT_SPEED;

        rb2D.velocity = moveVelocity;
    }
}
