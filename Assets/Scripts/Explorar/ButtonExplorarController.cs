using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExplorarController : MonoBehaviour
{
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
            SceneManager.LoadScene("NivelPrincipal");
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