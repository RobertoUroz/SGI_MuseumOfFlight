using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text nombreAvion;
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
        //StaticClass.CrossSceneInformation = nombreAvion.text;
        if (this.name == "Explorar") {
            SceneManager.LoadScene("Explorar");
        }
        else  {
            SceneManager.LoadScene("Subirse");
        }
    }

    public void OnPointerExit()
    {
    }
}
