using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Relatorio : MonoBehaviour
{
    private static System.DateTime data;
    private static System.DateTime hora;

    private static string caminhoDiretorioRelatorios;

    private static FileStream relatorio;
    private static StreamWriter streamWriterRelatorio;

    private void Start()
    {
        data = System.DateTime.Now;
        hora = System.DateTime.Now;

        data.ToShortDateString();
        hora.ToShortTimeString();

        caminhoDiretorioRelatorios = "C:/Relatórios - Arrasta!";

        criaDiretorioRelatorios();
    }

    private void criaDiretorioRelatorios()
    {
        if (!Directory.Exists(caminhoDiretorioRelatorios))
        {
            Directory.CreateDirectory(caminhoDiretorioRelatorios);
        }
    }

    private static void criaDiretorioIndividuo(string nomeIndividuo)
    {
        if (!Directory.Exists(caminhoDiretorioRelatorios + "/" + nomeIndividuo))
        {
            Directory.CreateDirectory(caminhoDiretorioRelatorios + "/" + nomeIndividuo);
        }
    }

    public static void criaRelatorioIndividuoMD1(string nomeIndividuo, int acertos, float tempo)
    {
        criaDiretorioIndividuo(nomeIndividuo);

        relatorio = new FileStream(caminhoDiretorioRelatorios + "/" + nomeIndividuo + "/MD1 - " + nomeIndividuo + " - " + data.ToString("dd_MM_yyyy") + " - " + hora.ToString("HH.mm.ss") + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
        streamWriterRelatorio = new StreamWriter(relatorio);

        streamWriterRelatorio.WriteLine("==================== RELATÓRIO - MÓDULO 01 ====================");
        streamWriterRelatorio.WriteLine("INDIVÍDUO    : " + nomeIndividuo);
        streamWriterRelatorio.WriteLine("ACERTO(S)    : " + acertos);
        streamWriterRelatorio.WriteLine("TEMPO (Seg.) : " + tempo);
        streamWriterRelatorio.WriteLine("===============================================================");
        streamWriterRelatorio.Close();
    }

    public static void criaRelatorioIndividuoMD2(string nomeIndividuo, int acertosDesejados, int acertosEfetuados, int erros, float tempo)
    {
        criaDiretorioIndividuo(nomeIndividuo);

        relatorio = new FileStream(caminhoDiretorioRelatorios + "/" + nomeIndividuo + "/MD2 - " + nomeIndividuo + " - " + data.ToString("dd_MM_yyyy") + " - " + hora.ToString("HH.mm.ss") + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
        streamWriterRelatorio = new StreamWriter(relatorio);

        streamWriterRelatorio.WriteLine("==================== RELATÓRIO - MÓDULO 02 ====================");
        streamWriterRelatorio.WriteLine("INDIVÍDUO             : " + nomeIndividuo);
        streamWriterRelatorio.WriteLine("ACERTOS DESEJADOS     : " + acertosDesejados);
        streamWriterRelatorio.WriteLine("ACERTO(S) EFETUADO(S) : " + acertosEfetuados);
        streamWriterRelatorio.WriteLine("ERRO(S) COMETIDO(S)   : " + erros);
        streamWriterRelatorio.WriteLine("TEMPO (Seg.)          : " + tempo);
        streamWriterRelatorio.WriteLine("===============================================================");
        streamWriterRelatorio.Close();
    }
}
