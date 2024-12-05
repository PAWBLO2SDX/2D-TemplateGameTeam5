using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool Idle = false;
    public bool Upwalk = false; 
    public bool Rightwalk = false;
    public bool Leftwalk = false;
    public bool Downwalk = false;
    private new Camera camera;
    private new Rigidbody2D rigidbody;


    private Vector2 velocity;

    public PlayerMovement(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }

    public float moveSpeed = 8f;
    
    private float inputAxis;
    internal Vector2 lastPos;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    private void Update()
    {
        if (velocity.y == 0f || velocity.x == 0f)
        {
            Idle = true;
        }
        else
        {
            Idle = false;
        }
     HorizontalMovement();
     VerticalMovement();
    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
        if (velocity.x > 0f)
        {
            Rightwalk = true;
            transform.eulerAngles = Vector3.zero;
        }
        if (velocity.x < 0f)
        {
            Leftwalk = true;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    private void VerticalMovement()
    {
        if (velocity.y > 0f)
        {
            Upwalk = true;
        }
        if (velocity.y < 0f)
        {
            Downwalk = true;
        }
        inputAxis = Input.GetAxis("Vertical");
        velocity.y = Mathf.MoveTowards(velocity.y, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody.position;
        position += velocity * Time.fixedDeltaTime;

        Vector2 leftEdge = camera.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = camera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        position.x = Mathf.Clamp(position.x, leftEdge.x + 0.5f, rightEdge.x - 0.5f);

        rigidbody.MovePosition(position);
    }

}


