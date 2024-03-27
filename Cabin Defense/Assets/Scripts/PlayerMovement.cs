using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public LayerMask groundLayer;

    public float horizontal = 8f;
    public float verticle = 8f;
    public float speed = 8f;

    public float jumpPower = 18f;
    public bool isJumping = true;

    //turning
   // private bool isFacingRight = true;
   // private bool isFacingup = false;

    //attacks 
    //private bool canAttack = false;
    public float attackDamage = 1f;
    public Transform attackPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, verticle * speed);
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        Debug.Log("moving");
        horizontal = ctx.ReadValue<Vector2>().x;
        verticle = ctx.ReadValue<Vector2>().y;
    }

}
