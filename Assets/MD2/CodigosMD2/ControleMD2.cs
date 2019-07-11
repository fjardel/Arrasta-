using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMD2 : MonoBehaviour
{
    private float tempo;

    private void Start()
    {
        tempo = 0;
        verificaCursor();
    }

    private void Update()
    {
        Cronometro();

        if (ColisaoMD2.contadorAcertosMD2 == PainelConfigMD2.numeroAcertosMD2)
        {
            Relatorio.criaRelatorioIndividuoMD2(PainelConfigMD2.nomeIndividuoMD2, PainelConfigMD2.numeroAcertosMD2, ColisaoMD2.contadorAcertosMD2, ColisaoMD2.contadorErrosMD2, Cronometro());
            SceneManager.LoadScene("Aprovado");
        }

        if (ColisaoMD2.contadorErrosMD2 == PainelConfigMD2.numeroErrosMD2)
        {
            Relatorio.criaRelatorioIndividuoMD2(PainelConfigMD2.nomeIndividuoMD2, PainelConfigMD2.numeroAcertosMD2, ColisaoMD2.contadorAcertosMD2, ColisaoMD2.contadorErrosMD2, Cronometro());
            SceneManager.LoadScene("Reprovado");
        }
    }

    private float Cronometro()
    {
        tempo = Time.timeSinceLevelLoad;
        return tempo;
    }

    private void verificaCursor()
    {
        if (PainelConfigMD2.cursoMouseMD2 == true)
        {
            Cursor.visible = true;
        }

        else
        {
            Cursor.visible = false;
        }
    }
}
