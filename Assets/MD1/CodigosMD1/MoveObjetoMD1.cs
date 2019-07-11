using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjetoMD1 : MonoBehaviour
{
    public float distanciaZ = 1;

    private Vector3 posicaoInicial;

    private bool mouseSobreObjeto;

    private void Start()
    {
        posicaoInicial = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), ((Screen.height) - (Screen.height / 4)), distanciaZ));
        mouseSobreObjeto = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            OnMouseDrag();
        }

        if (Input.GetMouseButtonUp(0))
        {
            OnMouseUp();
        }
    }

    private void OnMouseDrag()
    {
        if (mouseSobreObjeto == true)
        {
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanciaZ));
        }
        else
        {
            OnMouseUp();
        }
    }

    private void OnMouseUp()
    {
        this.transform.position = posicaoInicial;
    }

    private void OnMouseEnter()
    {
        mouseSobreObjeto = true;
    }

    private void OnMouseExit()
    {
        mouseSobreObjeto = false;
    }
}
