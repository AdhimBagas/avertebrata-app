using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitApp : MonoBehaviour
{
    // Start is called before the first frame update

    private Button quitButton;

    void Start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(ExitNow);
    }
    public void ExitNow()
    {
        Application.Quit();
    }

   
}
