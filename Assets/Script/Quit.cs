using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void salirDeLaAplicacion()
    {
        Application.Quit();
        Debug.Log("Has salido de la aplicacion");
    }
}
