using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
     public Button SinglePlayerButton;
     public Button MultiPlayerButton;


    // Start is called before the first frame update
    void Start()
    {
        SinglePlayerButton.onClick.AddListener(LoadSinglePlayer);
        MultiPlayerButton.onClick.AddListener(LoadMultiPlayer);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadSinglePlayer()
    {
        SceneManager.LoadScene("SingePlayer");
    }

    void LoadMultiPlayer()
    {
        SceneManager.LoadScene("MultiPlayer");
    }


}
