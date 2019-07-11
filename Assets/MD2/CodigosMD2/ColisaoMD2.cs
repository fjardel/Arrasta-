using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoMD2 : MonoBehaviour
{
    private MoveObjetoMD2 moMD2;

    public static int contadorAcertosMD2;
    private int contadorAcertosAUX;

    public static int contadorErrosMD2;
    private int contadorErrosAUX;

    private void Start()
    {
        moMD2 = GetComponent<MoveObjetoMD2>();

        contadorAcertosMD2 = 0;
        contadorAcertosAUX = 0;

        contadorErrosMD2 = 0;
        contadorErrosAUX = 0;
    }

    private void Update()
    {
        contadorAcertosMD2 = contadorAcertosAUX;

        contadorErrosMD2 = contadorErrosAUX;
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("ObstaculoMD2"))
        {
            contadorErrosAUX++;
            moMD2.VoltaObjetoPosicaoInicial();
        }

        else if (colisao.CompareTag("AlvoMD2"))
        {
            contadorAcertosAUX++;
            moMD2.VoltaObjetoPosicaoInicial();
            Dispensador.liberaRecompensa();
        }
    }
}
