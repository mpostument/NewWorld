using System;
using UnityEngine;

public class Movable : BaseMovable
{
    public bool isRunning;
    
    Rigidbody2D _rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {   
        float speed = isRunning ? runSpeed : walkSpeed;
        _rb.linearVelocity = direction * (speed * Time.fixedDeltaTime * 100);
    }

    public override void MoveTo(Vector2 direction)
    {
        this.direction = direction.normalized;
    }

    public override void SetRun(bool run)
    {
        isRunning = run;
    }
}
