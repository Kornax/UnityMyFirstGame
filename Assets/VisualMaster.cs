using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualMaster : MonoBehaviour {

    public Mapa mapa;
    public Personajes personajes;

    // Start is called before the first frame update
    void Start()
    {
        mapa.CrearMapa(this);
        personajes.CrearPersonajes();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void MoverJugador(int x, int y)
    {
        personajes.MoverJugador(x, y, 0);
    }
}
