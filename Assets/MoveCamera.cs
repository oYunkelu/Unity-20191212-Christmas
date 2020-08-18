using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveCamera : MonoBehaviour
{
    Animation an;
    public static int score = 0;  //得点管理
    GameObject msg;  //UI部品のテキスト
    private ParticleSystem particle;
    //public Text GoalText;

    public static int getScore()
    {
        return score;
    }

    //GameObject particle;
    // Use this for initialization
    void Start()
    {
        an = GetComponent<Animation>();
        msg = GameObject.Find("Text");
        //msg2 = GameObject.Find("Goal");

        particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Rotate(0, h, 0);
        if (v != 0)
        {
            an.Play("Run");
            transform.Translate(0, 0, v / 5);
        }
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Present15")
        {
            score += 5;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;
            //Destroy(this.gameObject);
            //Scoretext.text = string.Format("Score:{0}" ,score);
            particle.Play();
       
        }
        else if (c.gameObject.tag == "Present00")
        {
            score = score + 10;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

            //Scoretext.text = string.Format("Score:{0}" ,score);
        }
        else if (c.gameObject.tag == "Present34")
        {
            score = score + 20;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "Present01")
        {
            score = score + 40;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "Present36")
        {
            score = score + 20;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "Present23")
        {
            score = score + 10;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "Present05")
        {
            score = score + 30;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }

        //マイナスポイント　
        else if (c.gameObject.tag == "ball1")
        {
            score = score - 10;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "ball2")
        {
            score = score - 20;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "stickyellow")
        {
            score = score - 10;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }
        else if (c.gameObject.tag == "stickpink")
        {
            score = score - 40;
            Debug.Log(score);
            msg.GetComponent<Text>().text = "Score:" + score;

        }

        else if (c.gameObject.tag == "Goal")
        {
            score = score + 50;
            msg.GetComponent<Text>().text = "Goal!!";
            //msg2.GetComponent<Text>().text = "Goal!!";
            //GoalText.text = "Goal".ToString();
            SceneManager.LoadScene("Scenes/Lesson1-1");
        }

    }
   
}