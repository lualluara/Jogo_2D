using UnityEngine;

public class Ataque : MonoBehaviour
{
    [Header("Ataque")]
    public Transform attackPoint;
    public float attackRange = 0.7f;
    public int attackDamage = 1;
    public float attackCooldown = 0.4f;

    [Header("Camadas")]
    public LayerMask enemyLayer;

    private float proximoAtaque = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && Time.time >= proximoAtaque)
        {
            Atacar();
            proximoAtaque = Time.time + attackCooldown;
        }
    }
    void Atacar()
    {
        Collider2D[] inimigos = Physics2D.OverlapCircleAll(
            attackPoint.position,
            attackRange,
            enemyLayer
        );

        foreach (Collider2D inimigo in inimigos)
        {
            Enemy enemy = inimigo.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.ReceberDano(attackDamage);
            }
        }

        Debug.Log("Ataque realizado!");
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(
            attackPoint.position,
            attackRange
        );
    }
}
