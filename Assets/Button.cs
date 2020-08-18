using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

        /*public void ButtonClicked()
        {
            SceneManager.LoadScene("Scenes/SampleScene");
        } 
        // Use this for initialization
        /*void Start () {
            SceneManager.LoadScene(1);
        }

        // Update is called once per frame
        /*void Update () {
            if (Input.GetMouseButtonDown("space"))
            {
                SceneManager.LoadScene(1);
            }
        }*/
        public void ChangeModeSelect()
        {
            SceneManager.LoadScene("Scenes/SampleScene");
        }

    }
