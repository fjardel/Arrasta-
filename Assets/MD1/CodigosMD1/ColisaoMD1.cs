using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoMD1 : MonoBehaviour
{
    public static int contadorMD1;
    private int contadorAUX;

    private void Start()
    {
        contadorMD1 = 0;
        contadorAUX = 0;
    }

    public void Update()
    {
        contadorMD1 = contadorAUX;
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("AlvoMD1"))
        {
            contadorAUX++;
            Destroy(colisao.gameObject);
            Dispensador.liberaRecompensa();
        }
    }
}
