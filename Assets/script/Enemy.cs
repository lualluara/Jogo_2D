using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int vida = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReceberDano(int dano)
    {
        vida -= dano;

        Debug.Log("Inimigo recebeu " + dano + " de dano!");

        if (vida <= 0)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Destroy(gameObject);
    }
}

