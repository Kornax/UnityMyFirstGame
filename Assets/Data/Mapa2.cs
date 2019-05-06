using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa_1 : MonoBehaviour
{
    /// <summary>
    /// Estructura de datos para los Mapa
    /// 
    /// </summary>
    public int maxX = 10;
    public int maxY = 10;
    public int maxZ = 1;

    public MapaTipo[] mapaTipos;
    int[,] tiles;

    // Crear Mapa: CAMBIAR
    public void CrearMapa(VisualMaster vm)
    {
        tiles = new int[maxX, maxY];
        for(int x = 0; x < maxX; x++) {
            for(int y = 0; y < maxY; y++) {
                tiles[x, y] = Random.Range(0,3);
                //doy espacio al jugador
                if (x == 5 && y == 5)
                {
                    tiles[x, y] = 0;
                }
                MapaTipo tipo = mapaTipos[tiles[x, y]];
                //Creador del objeto
                GameObject go = (GameObject)Instantiate(tipo.VisualTipoDefault, new Vector3(x, 0, y), Quaternion.identity,this.transform);
                if (tiles[x,y] != 1)
                {
                    MapaClick mc = go.GetComponent<MapaClick>();
                    mc.posX = x;
                    mc.posY = y;
                    mc.vm = vm;
                }

            }
        }
        
    }

}