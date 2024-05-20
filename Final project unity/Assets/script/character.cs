using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    //make character move
    [SerializeField] private float _speed = 1;
    [SerializeField] private Rigidbody _rb;
    // for jumping 
    [SerializeField] private float _jumpForce = 200;


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        // use WASD keys to move or arrow keys
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity .y;
        _rb. velocity = vel;
        //use space bar to jump
        if (Input. GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * _jumpForce);
    }
}
