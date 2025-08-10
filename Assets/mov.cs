using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 30f;
    public float run = 60f;
    public float jumpForce = 30f;

    Rigidbody rd;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical).normalized;

        float currentSpeed = Input.GetButton("Submit") ? run : speed;

        rd.MovePosition(rd.position + transform.TransformDirection(move) * currentSpeed * Time.fixedDeltaTime);

        // ??? ??? ??? ?????? ??????? = 0 (???? ???? ??? ????? ???????)
        if (Input.GetButton("Jump") && Mathf.Abs(rd.linearVelocity.y) < 0.01f)
        {
            rd.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
