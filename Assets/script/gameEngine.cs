using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEngine : MonoBehaviour

{

    //int score, hiScore;
    public float hp;
    private GUIStyle guiS = new GUIStyle();

    // Start is called before the first frame update
    void Start()
    {
        
        //hp = 5;
        //hiScore = PlayerPrefs.GetInt("highScore", 0);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        //เช็คชน
        if (coll.gameObject.tag == "sweetTag")
        {
            hp+=1;
            Destroy(coll.gameObject);
        }
        else if (coll.gameObject.tag == "monsTag")
        {
            hp-=1;
           
        }
        //เปลี่ยนด่าน
        else if (coll.gameObject.tag == "gateTag")
        {
            //PlayerPrefs.SetInt("ja", 2);
            Application.LoadLevel("stage2");
        }
        else if (coll.gameObject.tag == "gateTag2")
        {
            //PlayerPrefs.SetInt("ja", 3);
            Application.LoadLevel("stage3");
        }
        else if (coll.gameObject.tag == "winTag")
        {
            //PlayerPrefs.SetInt("ja", 3);
            Application.LoadLevel("win");
        }

    }
    private void OnGUI()
    {
        guiS.fontSize = 25;
        guiS.normal.textColor = Color.white;
        //GUI.Label(new Rect(10, 40, 100, 100), "Score :" + score, guiS);
        GUI.Label(new Rect(10, 10, 100, 100), "HP :" + hp, guiS);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            //PlayerPrefs.SetInt("scoreG", score);
            Application.LoadLevel("over");
        }

    }
}
