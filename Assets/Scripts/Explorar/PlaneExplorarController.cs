using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneExplorarController : MonoBehaviour
{
    //posibles estados: rotar, escalar, mover (eje de las y), jugador (mover al jugador)
    public string estado = "mover";

    public GameObject jugador;

    private float sensitivity = 5.0f;
    private float rotationSensitivity = 90.0f;
    
    // Start is called before the first frame update
    public void Start()
    {
        //Mirar si es el avion elegido por el usuario
        if (StaticClass.CrossSceneInformation.Equals(this.transform.parent.name)) {
            this.transform.parent.gameObject.SetActive(true);
        } else {
            this.transform.parent.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Cambiar de estado
        cambioDeEstado();

        //TODO: Para la colision: hacer el cambio de transform (escalar, mover, rotar). 
        //Si choca, deshacerlo en el mismo frame (update), es decir, restando. Hacer una función de check?
        if (estado.Equals("mover")){
            float y = Input.GetAxis("Vertical");
            //if (transform.parent.localPosition.y + move.y < 11 && transform.parent.localPosition.y + move.y > 0)
            transform.parent.Translate(new Vector3(0, 1.0f, 0) * sensitivity * y * Time.deltaTime, Space.World);
        } else if (estado.Equals("rotar")) {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            transform.parent.Rotate(y * rotationSensitivity * Time.deltaTime, 0, -1.0f * x * rotationSensitivity * Time.deltaTime);
        } else if (estado.Equals("escalar")) {
            float scale = Input.GetAxis("Vertical");
            Vector3 newScale = transform.parent.localScale + (new Vector3(1, 1, 1) * scale * Time.deltaTime);
            if (newScale.x > 0.1 && newScale.y > 0.1 && newScale.z > 0.1)
                transform.parent.localScale = newScale; 
        }

    }

    private void cambioDeEstado() {
        if (Input.GetButtonDown("R1")) {
            if (estado.Equals("mover"))
                estado = "rotar";
            else if (estado.Equals("rotar"))
                estado = "escalar";
            else if (estado.Equals("escalar"))
                estado = "jugador";
            else if (estado.Equals("jugador"))
                estado = "mover";
            else
                estado = "jugador";
        }
        if (estado.Equals("jugador"))
            jugador.SendMessage("Movimiento");
        else
            jugador.SendMessage("Quieto");
    }
}
