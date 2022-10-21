using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExplorarController : MonoBehaviour
{

    public Camera camera;

    public Transform player;

    public GameObject punteroJugador;
    public GameObject punteroMover;
    public GameObject punteroRotar;
    public GameObject punteroEscalar;

    public Transform NivelPrincipalParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        //Mira que nombre tiene y va a la escena indicada con el valor del texto que tiene el nombre avion
        if (this.name.Equals("Si")) {
            //Punteros
            punteroJugador.SetActive(true);
            punteroMover.SetActive(false);
            punteroRotar.SetActive(false);
            punteroEscalar.SetActive(false);

            Debug.Log("CCC");

            camera.SendMessage("FadeOut");
            player.SetParent(NivelPrincipalParent);
            player.position = StaticClass.playerCoords;
            player.rotation = StaticClass.playerOrientation;
            camera.SendMessage("FadeIn");
        }
        else  {
            transform.parent.position = new Vector3(0, -1.873f, 0);
        }
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit button");
    }
}
