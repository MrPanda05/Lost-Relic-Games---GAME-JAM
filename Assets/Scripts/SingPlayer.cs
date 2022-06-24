using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingPlayer : MonoBehaviour
{
    public Player playerBools;

    [Header("Variables")]
    [SerializeField]
    private float m_Speed, Jforce;//Speed


    private Vector2 m_Dire;
    [SerializeField]private Rigidbody2D rg1, rg2;
    float  xAxis;
    [SerializeField]bool jumpKey, isGround;

    [Header("Layer")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private BoxCollider2D boxCollider;

    [SerializeField]internal bool qKey, isOnRadius, isOnButton;

    [SerializeField] private string killFloor, safeFloor;


    public AudioSource clip;

    public string alavanca;

    private void Awake()
    {

       // boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        GetInputs();
        if(!playerBools.ActP1)
        {
            if(!rg1)
            {
                return;
            }
            rg1.velocity = new Vector2(rg1.velocity.x, rg1.velocity.y);
        }
        if (!playerBools.ActP2)
        {
            if (!rg2)
            {
                return;
            }
            rg2.velocity = new Vector2(rg2.velocity.x, rg2.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        Movement();
        Jump();
    }

    //Mudar pra movimentação de platformer ao inves de top down
    void GetInputs()
    {
        qKey = Input.GetKeyDown(KeyCode.E);
        xAxis = Input.GetAxisRaw("Horizontal");
        jumpKey = Input.GetKey(KeyCode.Space);

        //m_Dire = new Vector2(xAxis, 0).normalized;//Make resultant = 1 when walking diagnoly

    }
    void Jump()
    {

            if (jumpKey && isGround)
            {
                if (playerBools.ActP1)
                {
                    if (!rg1)
                    {
                        return;
                    }
                    clip.Play();
                    rg1.velocity = new Vector2(0,1) * Jforce;
                    isGround = false;
                }
                if (playerBools.ActP2)
                {
                    if (!rg2)
                    {
                        return;
                    }
                   clip.Play();
                   rg2.velocity = new Vector2(0, 1) * Jforce;
                   isGround = false;
                }
         
            }
        //if (playerBools.ActP2)
        //{
        //    rg2.AddForce(new Vector3(0, 1, 0) * Jforce, ForceMode2D.Impulse);
        //}
        //rg1.AddForce(new Vector3(0, 1, 0), ForceMode2D.Impulse);
    }
    void Movement()
    {
        //rg.velocity = new Vector2(m_Dire.x * m_Speed, m_Dire.y * m_Speed);
        if(playerBools.ActP1)
        {
            if(!rg1)
            {
                return;
            }
            rg1.velocity = new Vector2(xAxis * m_Speed, rg1.velocity.y);
        }
        if (playerBools.ActP2)
        {
            if (!rg2)
            {
                return;
            }
            rg2.velocity = new Vector2(xAxis * m_Speed, rg2.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Button"))
        {
            isGround = true;
        }
        if (collision.gameObject.CompareTag("Player1"))
        {
            isGround = true;
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            isGround = true;
        }

        if(collision.gameObject.CompareTag(safeFloor))
        {
            isGround = true;
        }

            if (collision.gameObject.CompareTag(killFloor) || collision.gameObject.CompareTag("Acid"))
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(alavanca))
        {
            isOnRadius = true;
        }
        if (collision.gameObject.CompareTag("Button"))
        {
            isGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(alavanca))
        {
            isOnRadius = false;
        }
        //if (collision.gameObject.CompareTag("Button"))
        //{
        //    isOnButton = false;
        //}
    }
}
