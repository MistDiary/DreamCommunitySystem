using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchToDayButton;
    public Button switchToNightButton;
    public Button switchToDawnButton;
    public Button switchToDuskButton;

    // Start is called before the first frame update
    void Start()
    {
        switchToDayButton.onClick.AddListener(SwitchToDay);
        switchToNightButton.onClick.AddListener(SwitchToNight);
        switchToDawnButton.onClick.AddListener(SwitchToDawn);
        switchToDuskButton.onClick.AddListener(SwitchToDusk);



    }

    // Update is called once per frame
   
    public void SwitchToDay()
    {
        SceneManager.LoadScene("Day");
    }

    public void SwitchToNight()
    {
        SceneManager.LoadScene("Night");
    }
    public void SwitchToDawn()
    {
        SceneManager.LoadScene("Dawn");
    }
    public void SwitchToDusk()
    {
        SceneManager.LoadScene("Dusk");
    }

}
