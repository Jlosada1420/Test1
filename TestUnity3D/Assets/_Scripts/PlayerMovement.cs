using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private OldInput _oldInput;

    private Rigidbody _rigidbody;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        _oldInput = GetComponent<OldInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }


    public void Movement()
    {
        _rigidbody.velocity = new Vector3(_oldInput.horizontal * speed, _rigidbody.velocity.y, _oldInput.vertical * speed);
    }
}
