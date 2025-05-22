using UnityEngine;

public class Walk : MonoBehaviour
{
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3 (0.005f,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = gameObject.transform.position - new Vector3(0.005f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
           rb.linearVelocity = new Vector3(rb.linearVelocity.y,jumpForce);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f ,groundLayer);   
    }
}
