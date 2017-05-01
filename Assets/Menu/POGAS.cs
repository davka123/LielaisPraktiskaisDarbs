using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class POGAS : MonoBehaviour {

public void saktspeli_BTN(string jaunaspele)
    {
        SceneManager.LoadScene(jaunaspele);
    }
public void beigtspeli_BTN(string beigtspeli)
    {
        Application.Quit();
    }
}
