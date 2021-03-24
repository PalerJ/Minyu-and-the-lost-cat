using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtoMenu : MonoBehaviour
{
    public Button backToMenu;
    // Start is called before the first frame update
    void Start()
    {
        Button btnPlay5 = backToMenu.GetComponent<Button>();
        btnPlay5.onClick.AddListener(menuu);
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
