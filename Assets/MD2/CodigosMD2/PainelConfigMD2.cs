using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelConfigMD2 : MonoBehaviour
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

    public static string nomeIndividuoMD2;
    public static int numeroAcertosMD2;
    public static int numeroErrosMD2;

    public static bool reforcoAprendizadoMD2;
    public static bool cursoMouseMD2;

    private Rect painelConfigMD2;

    private void Start()
    {
        Cursor.visible = true;

        bitola = 20;

        larguraJanela = 500;
        alturaJanela = 350;

        xJanela = ((painelConfigMD2.width - painelConfigMD2.width) + bitola);
        yJanela = ((painelConfigMD2.height - painelConfigMD2.height) + bitola);

        larguraBotao = 80;
        alturaBotao = 30;

        larguraRotulo = 200;
        alturaRotulo = 20;

        larguraCampoTexto = 260;
        alturaCampoTexto = 20;

        nomeIndividuoMD2 = "";
        numeroAcertosMD2 = 0;
        numeroErrosMD2 = 0;

        reforcoAprendizadoMD2 = true;
        cursoMouseMD2 = false;

        painelConfigMD2 = new Rect(((Screen.width - larguraJanela) / 2), ((Screen.height - alturaJanela) / 2), larguraJanela, alturaJanela);
    }

    private void OnGUI()
    {
        painelConfigMD2 = GUI.Window(0, painelConfigMD2, BotoesPainelConfig, "Painel de Configuração - Módulo 02");
    }

    private void BotoesPainelConfig(int id)
    {
        GUI.Label(new Rect(xJanela, ((yJanela + alturaCampoTexto) + bitola), larguraRotulo, alturaRotulo), "Insira o nome do Indivíduo: ");
        nomeIndividuoMD2 = GUI.TextField(new Rect(xJanela + larguraRotulo, ((yJanela + alturaCampoTexto) + bitola), larguraCampoTexto, alturaCampoTexto), nomeIndividuoMD2, 40);

        GUI.Label(new Rect(xJanela, ((yJanela + (alturaCampoTexto * 2)) + (bitola * 2)), larguraRotulo, alturaRotulo), "Insira o objetivo de acertos: ");
        string numeroAcertosMD2AUX = GUI.TextField(new Rect(xJanela + larguraRotulo, ((yJanela + (alturaCampoTexto * 2)) + (bitola * 2)), (larguraCampoTexto / 3), alturaCampoTexto), numeroAcertosMD2.ToString(), 10);
        numeroAcertosMD2 = int.Parse(numeroAcertosMD2AUX);

        GUI.Label(new Rect(xJanela, ((yJanela + (alturaCampoTexto * 3)) + (bitola * 3)), larguraRotulo, alturaRotulo), "Insira o limite de erros: ");
        string numeroErrosMD2AUX = GUI.TextField(new Rect(xJanela + larguraRotulo, ((yJanela + (alturaCampoTexto * 3)) + (bitola * 3)), (larguraCampoTexto / 3), alturaCampoTexto), numeroErrosMD2.ToString(), 10);
        numeroErrosMD2 = int.Parse(numeroErrosMD2AUX);

        reforcoAprendizadoMD2 = GUI.Toggle(new Rect(xJanela, (((yJanela + (alturaCampoTexto * 4)) + (bitola * 4))), larguraRotulo, alturaRotulo), reforcoAprendizadoMD2, " Utilizar reforço automático?");
        cursoMouseMD2 = GUI.Toggle(new Rect(xJanela, (((yJanela + (alturaCampoTexto * 5)) + (bitola * 5))), larguraRotulo, alturaRotulo), cursoMouseMD2, " Exibir cursor do mouse?");

        if (GUI.Button(new Rect(((painelConfigMD2.width - larguraBotao) - bitola), ((painelConfigMD2.height - alturaBotao) - bitola), larguraBotao, alturaBotao), "Iniciar"))
        {
            SceneManager.LoadScene("MD2");
        }

        if (GUI.Button(new Rect(((painelConfigMD2.width - larguraBotao) - (larguraBotao * 1) - (bitola * 2)), ((painelConfigMD2.height - alturaBotao) - bitola), larguraBotao, alturaBotao), "Voltar"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

