using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float speed = 5f; // �÷��̾� �̵� �ӵ�
    public float jumpPower = 5f; // ���� ��
    private bool isGrounded; // �÷��̾ �ٴڿ� ��� �ִ��� Ȯ��

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    public void Move()
    {
        // �Է°� �޾ƿ���
        float moveHorizontal = Input.GetAxis("Horizontal"); // A�� D �Ǵ� ȭ��ǥ �¿�

        // �̵� ���� ����
        Vector2 movement = new Vector2(moveHorizontal * speed, rb.velocity.y);

        // �̵�
        rb.velocity = movement;
    }

    public void Jump()
    {
        // ���� �Է� ���� �� �ٴڿ� ����ִ��� Ȯ��
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }
    }

    // �ٴڿ� ��Ҵ��� Ȯ��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

