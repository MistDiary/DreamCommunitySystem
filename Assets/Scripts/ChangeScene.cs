using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangdeScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangdeScene()
    {
        //print("1111");
        SceneManager.LoadScene(1);
    }
    
}
