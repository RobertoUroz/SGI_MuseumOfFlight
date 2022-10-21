using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExplorarController : MonoBehaviour
{

    public Camera camera;

    public GameObject player;

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

            player.SetActive(false);
            camera.SendMessage("FadeOut");
            player.transform.position = StaticClass.playerCoords;
            player.transform.rotation = StaticClass.playerOrientation;
            camera.SendMessage("FadeIn");
            player.SetActive(true);   
        }
        transform.parent.position = new Vector3(0, -1.873f, 0);
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit button");
    }
}
