using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text nombreAvion;

    public CharacterController controller;

    public Camera camera;

    public GameObject player;

    public GameObject explorarParent;

    public GameObject planes;
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
        StaticClass.playerCoords = player.transform.position;
        StaticClass.playerOrientation = player.transform.rotation;
        StaticClass.exploreMode = true;
        camera.SendMessage("Quieto");
        camera.SendMessage("FadeOut");
        if (this.name.Equals("Explorar")) {
            player.SetActive(false);
            planes.SendMessage("CargarAvionCorrecto");
            player.transform.position = explorarParent.transform.position + new Vector3(-5f, 42.084f, 13.557f);
            player.transform.rotation = Quaternion.LookRotation(-Vector3.forward, Vector3.up);
            player.SetActive(true);
            camera.SendMessage("FadeIn");
            camera.SendMessage("Movimiento");
        }
        else  {
            CustomSceneManager.OnLoadSceneAsync("Subirse");
        }
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit button");
    }
}
