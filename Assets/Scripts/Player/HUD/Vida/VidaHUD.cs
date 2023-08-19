using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaHUD : MonoBehaviour
{
    public Player jogador;
    private int vidaAtual;
    private int totalCoracoes;
    public Sprite cCheio, cVazio;
    public GameObject coracaoGO;
    public Image[] coracao = new Image[5];
    

    private void Start()
    {
        vidaAtual = jogador.vidaPlayer;
        totalCoracoes = jogador.vidaBasePlayer;
        // -329x 153y
        
        

    }

    private void Update()
    {
        vidaAtual = jogador.vidaPlayer;
        totalCoracoes = jogador.vidaBasePlayer;

        for (int i = 0; i < totalCoracoes; i++)
        {
            coracao[i].enabled = true;

        }

        for (int i = 0; i < 5; i++)
        {
            if (coracao[i].enabled == true && i > totalCoracoes)
            {
                coracao[i].enabled = false;
            }
        }
        

        /*if (vidaAtual < 3)
        {
            coracao[2].sprite = cVazio;

            if (vidaAtual < 2)
            {
                coracao[1].sprite = cVazio;

                if(vidaAtual < 1)
                {
                    coracao[0].sprite = cVazio;
                }
            }
        }*/

        for (int i = 0; i < totalCoracoes; i++)
        {
            if (i < vidaAtual)
            {
                coracao[i].sprite = cCheio;
            }

            if (i >= vidaAtual)
            {
                coracao[i].sprite = cVazio;
            }
        }
    }
}
