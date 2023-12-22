using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{

    public string nombre;
    public string descripcion;
    public Sprite sprite;
    public int cantidadObjeto;

    public Objeto(string nuevoNombre, string nuevaDescripcion, Sprite nuevoSprite, int nuevaCantidadObjeto){

        nombre = nuevoNombre;
        descripcion = nuevaDescripcion;
        sprite = nuevoSprite; 

    }

    public void setNombre(string nuevoNombre){

        nombre = nuevoNombre;

    }

    public void setDescripcion(string nuevaDescripcion){

        descripcion = nuevaDescripcion;

    }

    public void setSprite(Sprite nuevoSprite){

        sprite = nuevoSprite;

    }

    public void setCantidadObjeto(int nuevaCantidadObjeto){

        cantidadObjeto = nuevaCantidadObjeto;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
