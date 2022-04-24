using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarContraseña : MonoBehaviour
{
    // Start is called before the first frame update
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousario;
    public GameObject cartelitoMensaje;
    public Text mensaje;
    void Start()
    {
        contraseniacorrecta = "12345";
        cartelitoMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void validarContrasenia()
    {
        contraseniausuario = ingresousario.text;
        if (contraseniausuario == contraseniacorrecta)
        {
            cartelitoMensaje.SetActive(true);
            mensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMensaje.SetActive(true);
            mensaje.text = "Contraseña incorrecta";
            Debug.Log("contraseña incorrecta");
        }
    }

    }



