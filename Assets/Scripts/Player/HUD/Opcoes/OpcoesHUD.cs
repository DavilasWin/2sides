using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcoesHUD : MonoBehaviour
{
    public GameObject opcoesPrincipal;
    public float tempoAberto;
    public void Opcoes()
    {

    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    private void Update()
{
    Debug.Log(opcoesPrincipal.activeSelf);

    if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (opcoesPrincipal.activeSelf)
        {
            // Se as opções estão abertas, fecha o menu
            opcoesPrincipal.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            // Se as opções estão fechadas, abre o menu
            opcoesPrincipal.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}


    void Voltar()
    {
        opcoesPrincipal.SetActive(false);
    }
}
