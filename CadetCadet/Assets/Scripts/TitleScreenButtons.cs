using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//9/10/2021
//Class used as a base prototype to move from Title Scene to Level 1 Scene
//should be implemented later on in either the GameManger object (which will be a DoNotDestroy object) or in a more
//robust class designed for the title screen. 
public class TitleScreenButtons : MonoBehaviour
{
    //private int x;
    // Start is called before the first frame update
    void Start()
    {
        //x = 0;
    }

    public void SceneChange(int x)
    {
        SceneManager.LoadScene(x);
    }

    public void CloseGame()
    {
        //Display thanks for playing!
        Application.Quit();
    }
}
