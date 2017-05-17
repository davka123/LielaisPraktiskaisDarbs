using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class time : MonoBehaviour {

    public Text timer;
    public bool trigger = false;
    public bool zaudejums = false;
    private bool finnished = false;
    private float startTime = 40;
    // Use this for initialization
	void Start () {
        timer.material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
        if (finnished)
        {
            return;
        }
        startTime -= Time.deltaTime;
        timer.text = startTime.ToString("f2");
        if (startTime <= 10)
        {
            timer.material.color = Color.red;
        }
        if (startTime <= 0)
        {
            timer.material.color = Color.white;
            timer.fontSize = 35;
            timer.text = "Spēle ir zaudēta!";
            zaudejums = false;
            Application.Quit();
            
        }
	}
    public void Finnish()
    {
        if (zaudejums == false)
        {
            trigger = true;
            startTime = 60;
            timer.material.color = Color.white;
        }
        else timer.text = "Spēle zaudēta";

    }
    
    public void beigas()
    {
        if (zaudejums == false)
        {
            if (trigger)
            {
                finnished = true;
                timer.fontSize = 40;
                timer.material.color = Color.white;
                timer.text = "Spēle izieta";
            }
        }
    }
}
