using UnityEngine;

public class CTAPlayerMove : MonoBehaviour
{
    //Movement
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    //Combat
    public int health = 3;
    public float invincibleTimeAfterHurt = 2;



    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
   private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    void Hurt()
    {
        health--;
        if (health <= 0)
            Application.LoadLevel(Application.loadedLevel);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        CTAEnemy CTAEnemy = collision.collider.GetComponent<CTAEnemy>();    
        if (CTAEnemy != null)
        {
            Hurt();
        }
    }
}
