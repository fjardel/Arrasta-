using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelConfigMD1 : MonoBehaviour
{
    private float bitola;

    private float larguraJanela;
    private float alturaJanela;

    private float xJanela;
    private float yJanela;

    private float larguraBotao;
    private float alturaBotao;

    private float larguraRotulo;
    private float alturaRotulo;

    private float larguraCampoTexto;
    private float alturaCampoTexto;

    public static string nomeIndividuoMD1;

    public static bool reforcoAprendizadoMD1;
    public static bool cursoMouseMD1;

    private Rect painelConfigMD1;

    private void Start()
    {
        Cursor.visible = true;

        bitola = 20;

        larguraJanela = 500;
        alturaJanela = 300;

        xJanela = ((painelConfigMD1.width - painelConfigMD1.width) + bitola);
        yJanela = ((painelConfigMD1.height - painelConfigMD1.height) + bitola);

        larguraBotao = 80;
        alturaBotao = 30;

        larguraRotulo = 200;
        alturaRotulo = 20;

        larguraCampoTexto = 260;
        alturaCampoTexto = 20;

        nomeIndividuoMD1 = "";

        reforcoAprendizadoMD1 = true;
        cursoMouseMD1 = false;

        painelConfigMD1 = new Rect(((Screen.width - larguraJanela) / 2), ((Screen.height - alturaJanela) / 2), larguraJanela, alturaJanela);
    }

    private void OnGUI()
    {
        painelConfigMD1 = GUI.Window(0, painelConfigMD1, BotoesPainelConfig, "Painel de Configuração - Módulo 01");
    }

    private void BotoesPainelConfig(int id)
    {
        GUI.Label(new Rect(xJanela, ((yJanela + alturaCampoTexto) + bitola), larguraRotulo, alturaRotulo), "Insira o nome do Indivíduo: ");
        nomeIndividuoMD1 = GUI.TextField(new Rect(xJanela + larguraRotulo, ((yJanela + alturaCampoTexto) + bitola), larguraCampoTexto, alturaCampoTexto), nomeIndividuoMD1, 40);

        reforcoAprendizadoMD1 = GUI.Toggle(new Rect(xJanela, (((yJanela + (alturaCampoTexto * 2)) + (bitola * 2))), larguraRotulo, alturaRotulo), reforcoAprendizadoMD1, " Utilizar reforço automático?");
        cursoMouseMD1 = GUI.Toggle(new Rect(xJanela, (((yJanela + (alturaCampoTexto * 3)) + (bitola * 3))), larguraRotulo, alturaRotulo), cursoMouseMD1, " Exibir cursor do mouse?");

        if (GUI.Button(new Rect(((painelConfigMD1.width - larguraBotao) - bitola), ((painelConfigMD1.height - alturaBotao) - bitola), larguraBotao, alturaBotao), "Iniciar"))
        {
            SceneManager.LoadScene("MD1");
        }

        if (GUI.Button(new Rect(((painelConfigMD1.width - larguraBotao) - (larguraBotao * 1) - (bitola * 2)), ((painelConfigMD1.height - alturaBotao) - bitola), larguraBotao, alturaBotao), "Voltar"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

