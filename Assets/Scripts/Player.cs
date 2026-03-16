using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpForce;
    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigid.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
