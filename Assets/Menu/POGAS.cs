using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class POGAS : MonoBehaviour {

public void saktspeli_BTN(string jaunaspele)
    {
        SceneManager.LoadScene(jaunaspele);
        GameObject lightGameObject = new GameObject("The Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.blue;
        lightGameObject.transform.position = new Vector3(25, -1, -1);
        Application.Quit();
        
        }
public void beigtspeli_BTN(string beigtspeli)
    {
        Application.Quit();
    }
}
