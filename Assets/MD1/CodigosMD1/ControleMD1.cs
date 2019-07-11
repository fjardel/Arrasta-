using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMD1 : MonoBehaviour
{
    private string modulo;
    private float tempo;

    private void Start()
    {
        tempo = 0;
        verificaCursor();
    }

    public void Update()
    {
        Cronometro();

        if (ColisaoMD1.contadorMD1 == 14)
        {
            Relatorio.criaRelatorioIndividuoMD1(PainelConfigMD1.nomeIndividuoMD1, ColisaoMD1.contadorMD1, Cronometro());
            SceneManager.LoadScene("Aprovado");
        }
    }

    private float Cronometro()
    {
        tempo = Time.timeSinceLevelLoad;
        return tempo;
    }

    private void verificaCursor()
    {
        if (PainelConfigMD1.cursoMouseMD1 == true)
        {
            Cursor.visible = true;
        }

        else
        {
            Cursor.visible = false;
        }
    }
}
