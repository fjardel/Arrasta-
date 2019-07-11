using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class Dispensador : MonoBehaviour
{
    private static string msg;

    private static SerialPort porta = new SerialPort("COM3", 9600);

    private void Start()
    {
        msg = "1";
    }

    private void Update()
    {
        if(PainelConfigMD1.reforcoAprendizadoMD1 == false || PainelConfigMD2.reforcoAprendizadoMD2 == false)
        {
            msg = null;
        }
    }

    public static void liberaRecompensa()
    {
        print(msg);
        abrePorta();
        enviaMensagem(msg);
        fechaPorta();
    }

    private static void abrePorta()
    {
        if (!porta.IsOpen)
        {
            porta.Open();
        }
    }

    private static void enviaMensagem(string msg)
    {
        porta.Write(msg);
    }

    private static void fechaPorta()
    {
        if (porta.IsOpen)
        {
            porta.Close();
        }
    }
}
