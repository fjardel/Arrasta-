using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaCenarioMD2 : MonoBehaviour
{
    public float distanciaZ = 1;

    public GameObject objeto;
    private Vector3 posicaoInicialObjeto;

    public GameObject obstaculo;
    private Vector3 posicaoObstaculo;

    public GameObject alvo;
    private Vector3 posicaoAlvo;

    private void Start()
    {
        posicaoInicialObjeto = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 4), (Screen.height / 2), distanciaZ));

        posicaoObstaculo = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), (Screen.height / 2), distanciaZ));

        posicaoAlvo = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (Screen.width / 4)), (Screen.height / 2), distanciaZ));

        criaObjetos();
    }

    private void criaObjetos()
    {
        Instantiate(objeto, posicaoInicialObjeto, Quaternion.identity);
        Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);
        Instantiate(alvo, posicaoAlvo, Quaternion.identity);
    }
}
