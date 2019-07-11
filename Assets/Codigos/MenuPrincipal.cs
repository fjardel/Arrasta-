using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    private float bitola;

    private float larguraJanela;
    private float alturaJanela;

    private float yJanela;

    private float larguraBotao;
    private float alturaBotao;

    private float larguraRotulo;
    private float alturaRotulo;

    private Rect janelaMenu;

    private void Start()
    {
        Cursor.visible = true;

        bitola = 20;

        larguraJanela = 260;
        alturaJanela = 300;

        yJanela = ((janelaMenu.height - janelaMenu.height) + bitola);

        larguraBotao = 80;
        alturaBotao = 30;

        janelaMenu = new Rect((((Screen.width - larguraJanela) / 2)), (((Screen.height - alturaJanela) / 2)), larguraJanela, alturaJanela);
    }

    private void OnGUI()
    {
        janelaMenu = GUI.Window(0, janelaMenu, BotoesJanelaMenu, "Bem vindo(a) ao Arrasta!");
    }

    private void BotoesJanelaMenu(int id)
    {
        if (GUI.Button(new Rect(((janelaMenu.width - larguraBotao) / 2), ((yJanela + alturaBotao) + bitola), larguraBotao, alturaBotao), "Módulo 01"))
        {
            SceneManager.LoadScene("PainelConfigMD1");
        }

        if (GUI.Button(new Rect(((janelaMenu.width - larguraBotao) / 2), ((yJanela + (alturaBotao * 2)) + (bitola * 2)), larguraBotao, alturaBotao), "Módulo 02"))
        {
            SceneManager.LoadScene("PainelConfigMD2");
        }

        if (GUI.Button(new Rect(((janelaMenu.width - larguraBotao) / 2), ((yJanela + (alturaBotao * 3)) + (bitola * 3)), larguraBotao, alturaBotao), "Sobre"))
        {
            Application.OpenURL("http://www.ufpa.br/eep/");
        }

        if (GUI.Button(new Rect(((janelaMenu.width - larguraBotao) / 2), ((yJanela + (alturaBotao * 4)) + (bitola * 4)), larguraBotao, alturaBotao), "Sair"))
        {
            Application.Quit();
        }
    }
}
