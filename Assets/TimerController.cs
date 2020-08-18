using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
    public Text timerText;
    public float totalTime;
    int seconds;
    public Button disableAdsButton;
	// Use this for initialization
		void Start () {
	
	}

    // Update is called once per frame
    void Update () {

    /*public void OnClickButtonStart()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
        if(totalTime < 1)
        {
            timerText.text = "Start!".ToString();
            disableAdsButton.gameObject.SetActive(false);
        }*/

        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
        if (totalTime < 1)
        {
            timerText.text = "Start!".ToString();
            //disableAdsButton.gameObject.SetActive(false);

        }
        if (totalTime < -1)
        {
            timerText.text = "".ToString();
        }
       

    }
}
