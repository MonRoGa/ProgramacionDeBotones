using UnityEngine;
using TMPro;

public class ControlarFuente : MonoBehaviour
{
    public TMP_Text titulo;

    public void AumentarFuente()
    {
        titulo.fontSize = 60;
    }

    public void DisminuirFuente()
    {
        titulo.fontSize = 36;
    }
}