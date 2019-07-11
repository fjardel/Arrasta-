using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaCenarioMD1 : MonoBehaviour
{
    public float distanciaZ = 1;

    private float bitola;

    public GameObject objetoCentral;
    private Vector3 posicaoInicialObjetoCentral;

    public GameObject alvos;
    private Vector3 posicaoAlvos1;
    private Vector3 posicaoAlvos2;
    private Vector3 posicaoAlvos3;
    private Vector3 posicaoAlvos4;
    private Vector3 posicaoAlvos5;
    private Vector3 posicaoAlvos6;
    private Vector3 posicaoAlvos7;
    private Vector3 posicaoAlvos8;
    private Vector3 posicaoAlvos9;
    private Vector3 posicaoAlvos10;
    private Vector3 posicaoAlvos11;
    private Vector3 posicaoAlvos12;
    private Vector3 posicaoAlvos13;
    private Vector3 posicaoAlvos14;

    private void Start()
    {
        bitola = 150;

        posicaoInicialObjetoCentral = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), ((Screen.height) - (Screen.height / 4)), distanciaZ));

        posicaoAlvos1 = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), (Screen.height / 2), distanciaZ));

        posicaoAlvos2 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - bitola), (Screen.height / 2), distanciaZ));
        posicaoAlvos3 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - (bitola * 2)), (Screen.height / 2), distanciaZ));
        posicaoAlvos4 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - (bitola * 3)), (Screen.height / 2), distanciaZ));

        posicaoAlvos5 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + bitola), (Screen.height / 2), distanciaZ));
        posicaoAlvos6 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (bitola * 2)), (Screen.height / 2), distanciaZ));
        posicaoAlvos7 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (bitola * 3)), (Screen.height / 2), distanciaZ));

        posicaoAlvos8 = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), (Screen.height / 4), distanciaZ));

        posicaoAlvos9 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - bitola), (Screen.height / 4), distanciaZ));
        posicaoAlvos10 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - (bitola * 2)), (Screen.height / 4), distanciaZ));
        posicaoAlvos11 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) - (bitola * 3)), (Screen.height / 4), distanciaZ));

        posicaoAlvos12 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + bitola), (Screen.height / 4), distanciaZ));
        posicaoAlvos13 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (bitola * 2)), (Screen.height / 4), distanciaZ));
        posicaoAlvos14 = Camera.main.ScreenToWorldPoint(new Vector3(((Screen.width / 2) + (bitola * 3)), (Screen.height / 4), distanciaZ));

        criaObjetos();
    }

    private void criaObjetos()
    {
        Instantiate(objetoCentral, posicaoInicialObjetoCentral, Quaternion.identity);

        Instantiate(alvos, posicaoAlvos1, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos2, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos3, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos4, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos5, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos6, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos7, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos8, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos9, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos10, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos11, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos12, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos13, Quaternion.identity);
        Instantiate(alvos, posicaoAlvos14, Quaternion.identity);
    }
}
