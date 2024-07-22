using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float verticalSpeed = 20;
    [SerializeField] float horizontalSpeed = 20;

    private float verticalInput;
    private float horizontalInput;

    [SerializeField] string horizontalInputAxisName;
    [SerializeField] string verticalInputAxisName;

    // Update is called once per frame
    void Update()
    {
        // Get Inputs
        horizontalInput = Input.GetAxis(horizontalInputAxisName);
        verticalInput = Input.GetAxis(verticalInputAxisName);

        // Move vertically
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);

        // Turn horizontally
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
