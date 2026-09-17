using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

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
        if (Input.GetKeyDown(KeyCode.Space))//reconhece quando apertarem a tecla "espaço"
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);//Concede o impulso para o player
        }


    }
}
