using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalSpeed = 20;
    public float horizontalSpeed = 20;

    private float verticalInput;
    private float horizontalInput;

    public bool isPlayer2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get Inputs
        horizontalInput = Input.GetAxis(isPlayer2 ? "Horizontal 2" : "Horizontal");
        verticalInput = Input.GetAxis(isPlayer2 ? "Vertical 2" : "Vertical");

        // Move vertically
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);

        // Turn horizontally
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
