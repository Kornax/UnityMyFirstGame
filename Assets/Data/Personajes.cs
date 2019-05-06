using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes : MonoBehaviour
{
    public GameObject Jugador;
    public PersonajeTipo[] personajes;
    // Start is called before the first frame update
    public void CrearPersonajes()
    {
        foreach (PersonajeTipo pjs in personajes)
        {
            GameObject obj = Instantiate(pjs.VisualTipoDefault, new Vector3(5, 0, 5), Quaternion.identity,this.transform);
            //obj.transform.localScale = new Vector3(pjs.Size, pjs.Size, pjs.Size);
            Jugador = obj;
        }
    }

    //Mover Jugador
    public void MoverJugador(int x, int y, int z)
    {
        Jugador.transform.position = new Vector3(x, z, y);
    }
}
