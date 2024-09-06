using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jumpForce = 5f; // Zıplama kuvveti
    [SerializeField]
    private bool isGrounded; // Yerde olup olmadığımızı kontrol eder
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Y ekseni yerine Z eksenini kullanıyorsanız, Vector3.forward ile değiştirin
        isGrounded = false; // Zıpladıktan sonra yerde değiliz
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane") || collision.gameObject.CompareTag("Stairs") || collision.gameObject.CompareTag("Wall"))
        {
            isGrounded = true; // Yere değdiğimizde isGrounded true olur
        }
    }
}
