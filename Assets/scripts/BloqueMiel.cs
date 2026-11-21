using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueMiel : Bloques
{
    // ESTE BLOQUE REALENTIZA LA BOLA HACIENDOLA MAS LENTA HASTA CASI FRENARLA CON UN MULTIPLICADOR DE 0.5
    void Start()
    {
        resistencia = 1;
    }

    public override void rebotarbola()
    {
        base.rebotarbola();
    }
}
