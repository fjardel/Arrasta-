using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaCenarioMD3 : MonoBehaviour
{
    public float distanciaZ = 1;

    public GameObject pivo;
    private Vector3 posicaoInicialPivo;

    public GameObject alvoA;
    private Vector3 posicaoAlvoA;

    public GameObject alvoB;
    private Vector3 posicaoAlvoB;

    public GameObject alvoC;
    private Vector3 posicaoAlvoC;

    private void Start()
    {
        posicaoInicialPivo = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), ((Screen.height / 2) + (Screen.height / 4)), distanciaZ));

        posicaoAlvoA = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 4), ((Screen.height / 2) - (Screen.height / 4)), distanciaZ));

        posicaoAlvoB = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), ((Screen.height / 2) - (Screen.height / 4)), distanciaZ));

        posicaoAlvoC = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (Screen.width / 4)), ((Screen.height / 2) - (Screen.height / 4)), distanciaZ));

        criaObjetos();
    }

    private void criaObjetos()
    {
        Instantiate(pivo, posicaoInicialPivo, Quaternion.identity);
        Instantiate(alvoA, posicaoAlvoA, Quaternion.identity);
        Instantiate(alvoB, posicaoAlvoB, Quaternion.identity);
        Instantiate(alvoC, posicaoAlvoC, Quaternion.identity);
    }
}
