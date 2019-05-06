using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo
{
    public MapaTipo tipo;
    public List<Nodo> vecinos;
    public Nodo()
    {
        vecinos = new List<Nodo>();
    }

    public GameObject visual;

}

public class Mapa : MonoBehaviour
{
    /// <summary>
    /// Estructura de datos para los Mapa
    /// 
    /// </summary>
    public int maxX = 10;
    public int maxY = 10;
    public int maxZ = 1;

    public MapaTipo[] mapaTipos;
    public Nodo[,] Grafica;

    // Crear Mapa: CAMBIAR
    public void CrearMapa(VisualMaster vm)
    {
        Grafica = new Nodo[maxX, maxY];
        for(int x = 0; x < maxX; x++) {
            for(int y = 0; y < maxY; y++) {
                int t = Random.Range(0,3);
                Debug.Log(t);
                MapaTipo tipo = mapaTipos[t];
                //doy espacio al jugador
                if (x == 5 && y == 5)
                    t = 0;
                Debug.Log(tipo);
                //Grafica[x, y].tipo = new MapaTipo();
                //Grafica[x, y].tipo = tipo;
                //Creador del objeto
                GameObject go = (GameObject)Instantiate(tipo.VisualTipoDefault, new Vector3(x, 0, y), Quaternion.identity,this.transform);
                if (t != 1)
                {
                    MapaClick mc = go.GetComponent<MapaClick>();
                    mc.posX = x;
                    mc.posY = y;
                    mc.vm = vm;
                }

            }
        }
        
    }
    void GenerarPathFinfingGrafica()
    {
        for (int x = 0; x < maxX; x++){
            for (int y = 0; y < maxY; y++){
                if (x > 0)
                    Grafica[x, y].vecinos.Add(Grafica[x - 1, y]);
                if (x < maxX)
                    Grafica[x, y].vecinos.Add(Grafica[x + 1, y]);
                if (y > 0)
                    Grafica[x, y].vecinos.Add(Grafica[x, y - 1]);
                if (y < maxY)
                    Grafica[x, y].vecinos.Add(Grafica[x, y + 1]);
            }
        }
    }

}