using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D _rb;
    public float speed = 10f;
    public float jumpStrength = 5f;

    private bool isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            _rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveX * speed, _rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}