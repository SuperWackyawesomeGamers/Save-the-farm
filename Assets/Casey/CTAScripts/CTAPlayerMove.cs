 using UnityEngine;
using UnityEngine.SceneManagement;

public class CTAPlayerMove : MonoBehaviour
{
    //Movement
    public float MovementSpeed = 1;
    public float JumpForce = 1;
   
    //Health
    public int maxHealth = 100;
    public int currentHealth;
    public CTAHealthBar healthBar;


    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
   private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMAxHealth(maxHealth);
        
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
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            TakeDamage(20);
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Casey Scene");
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
