using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiosDeescenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Canbiar a la escena de opciones
    public void escenaOpciones()
    {
        SceneManager.LoadScene("MenuOpciones");
    }
    //Cambiar a la escena de menu principal
    public void escenaOpcionesMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    //Cambiar a la escena de DemoScene 1
    public void escenaDemoScene1()
    {
        SceneManager.LoadScene("DemoScene 1");
    }
}
