using UnityEngine;
using TMPro;

public class NavegacionUI : MonoBehaviour
{
    public TMP_Text titulo;

    public void MostrarInicio()
    {
        titulo.text = "INICIO";
    }

    public void MostrarCatalogo()
    {
        titulo.text = "CATÁLOGO";
    }

    public void MostrarContacto()
    {
        titulo.text = "CONTACTO";
    }
}