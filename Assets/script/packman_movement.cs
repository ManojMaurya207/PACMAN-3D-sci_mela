using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packman_movement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 5.0f;
    public float smoothTime = 0.1f;
    public Transform cam;
    private float smoothVelocity;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        direction = direction.normalized;

        if (direction.magnitude >= 0.1f)

        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
