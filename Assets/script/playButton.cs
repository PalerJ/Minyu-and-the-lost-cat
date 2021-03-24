using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{
    public Button play, menu;
    // Start is called before the first frame update
    void Start()
    {
        Button btnPlay = play.GetComponent<Button>();
        btnPlay.onClick.AddListener(playG);

        Button btnPlay2 = menu.GetComponent<Button>();
        btnPlay2.onClick.AddListener(menuu);

       

    }
    void playG()
    {
        Application.LoadLevel("SampleScene");
    }
    void menuu()
    {
        Application.LoadLevel("menu");
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
