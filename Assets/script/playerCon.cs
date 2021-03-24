using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCon : MonoBehaviour
{
    Animator an;

    public float speed;
    public float jumpF;
    private float moveInput;

    private Rigidbody2D rb;
    private bool facingR = true;

    public GameObject character;
    private bool onGround;
    public Transform groundChk;
    //public float chkRadius;
    public LayerMask whatGround;
    

    public int exJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = character.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        anim();
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = Vector2.up * jumpF;
            onGround = false;

        }

       
    }

    void FixedUpdate()
    {
        //onGround = Physics2D.OverlapCircle(groundChk.position, chkRadius, whatGround);
        

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        
        if (facingR == false && moveInput > 0)
        {
            flip();
        }else if (facingR == true && moveInput < 0)
        {
            flip();
        }
    }

    void flip()
    {
        facingR = !facingR;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        onGround = true;
    }

    void anim()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            an.SetBool("isWalk", true);
        }
        else
        {
            an.SetBool("isWalk", false);
        }
    }


}