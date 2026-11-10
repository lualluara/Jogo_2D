using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public GameObject Painelgameover;
    public GameObject PainelPause;

    bool pausado = false;
    bool jogoacabou = false;

    void Start()
    {
        PainelPause.SetActive(false); //SetActive vai desativar e ativar o game object dentro do nosso jogo
        Painelgameover.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pausado)
            {
                Continuar();
            }else
            {
                Pausar();
            }
        }

    }

    public void Pausar()
    {
        if(jogoacabou == false)
        {
            pausado = true;
            PainelPause.SetActive(true);
            Time.timeScale = 0f;
        }



    }

    public void Continuar()
    {
        pausado = false;
        PainelPause?.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MostrarGameOver()
    {
        jogoacabou = true;
        Painelgameover.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }





}
