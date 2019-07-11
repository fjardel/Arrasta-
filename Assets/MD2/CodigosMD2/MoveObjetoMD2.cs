using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjetoMD2 : MonoBehaviour
{
    public float velocidade = 4;

    public float distanciaZ = 1;

    private Vector3 posicaoInicial;

    private void Start()
    {
        posicaoInicial = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 4), (Screen.height / 2), distanciaZ));
    }

    private void Update()
    {
        MoveObjeto();
    }

    private void MoveObjeto()
    {
        this.transform.Translate((Vector3.right * Time.deltaTime) * velocidade);
    }

    public void VoltaObjetoPosicaoInicial()
    {
        this.transform.position = posicaoInicial;
    }
}
