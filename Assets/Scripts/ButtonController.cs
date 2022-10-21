using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text nombreAvion;

    public Camera camera;

    public Transform player;

    public Transform ExplorarParent;
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
        Debug.Log("AAA");
        camera.SendMessage("FadeOut");
        if (this.name.Equals("Explorar")) {
            StaticClass.exploreMode = true;
            player.localPosition = ExplorarParent.position + new Vector3(-5f, 42.084f, 13.557f);
            Debug.Log("DDD: " + player.localPosition + ", " + ExplorarParent.position);

            player.localRotation = Quaternion.LookRotation(new Vector3(-5f, 42.084f, 13.557f) - new Vector3(-5f, 42.084f, 12.557f), Vector3.up);
            camera.SendMessage("FadeIn");
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
