using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private readonly float _speed = 25.0f;
    private readonly float _turnSpeed = 45.0f;
    private float _horizontalInput;
    private float _forwardInput;

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed * _forwardInput));
        transform.Rotate(Vector3.up, (Time.deltaTime * _turnSpeed * _horizontalInput));
    }
}