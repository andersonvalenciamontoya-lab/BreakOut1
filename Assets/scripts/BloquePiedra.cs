using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquePiedra : Bloques
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 5;
    }

    public override void rebotarbola()
    {
        base.rebotarbola();
    }
}
