using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button plays, howTo, credit;
    // Start is called before the first frame update
    void Start()
    {
        Button btnPlay = plays.GetComponent<Button>();
        btnPlay.onClick.AddListener(playGg);

        Button btnPlay3 = howTo.GetComponent<Button>();
        btnPlay3.onClick.AddListener(howToP);

        Button btnPlay4 = credit.GetComponent<Button>();
        btnPlay4.onClick.AddListener(credits);
    }
    void playGg()
    {
        Application.LoadLevel("SampleScene");
    }

    void howToP()
    {
        Application.LoadLevel("howTo");
    }
    void credits()
    {
        Application.LoadLevel("credit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
