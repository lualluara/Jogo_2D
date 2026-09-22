using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //reconhece o movimento horizontal
        rb.linearVelocity = new Vector2(moveHorizontal *  speed, rb.linearVelocity.y); //adiciona o movimento horizontal

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)//reconhece quando apertarem a tecla "espaço"
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);//Concede o impulso para o player
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;//Vai comparar parar ver se o jogador está pulando
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false; //Vai reconhecer quando o jogador encostar no chão
    }



}
