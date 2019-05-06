using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaClick : MonoBehaviour
{
    public int posX;
    public int posY;
    public VisualMaster vm;


    private void OnMouseDown()
    {
        Debug.Log("X:"+ posX + ", Y:" + posY);
        vm.MoverJugador(posX, posY);
    }
}
