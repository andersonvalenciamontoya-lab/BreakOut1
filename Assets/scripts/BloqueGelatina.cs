using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueGelatina : Bloques
{
    // ESTE BLOQUE HARA QUE LA BOLA REBOTE MUCHO MAS RAPIDO QUE EL RESTO DE BLOQUES, MULTIPLICANDO
    // SU VELOCIDAD X2 POR CADA REBOTE SEGUIDO(SE REINICIA SI LA BOLA REVOTA CON UN BLOQUE DISTINTO) QUE LE DE LA BOLA, HASTA UN MÁXIMO DE X8
    void Start()
    {
        resistencia = 2;
    }

    public override void rebotarbola()
    {
        base.rebotarbola();
    }
}
