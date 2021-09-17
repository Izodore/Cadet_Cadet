using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    private bool[] direction;

    public bool[] Direction
    {
        get
        {
            return direction;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        direction = new bool[4] { false, false, false, false };
    }

    // Update is called once per frame
    void Update()
    {
        ResetKeys();
        HandleKeyboardInput();
    }

    void ResetKeys()
    {
        for(int i = 0; i < direction.Length; i++)
        {
            direction[i] = false;
        }
    }

    void HandleKeyboardInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction[0] = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction[1] = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction[2] = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction[3] = true;
        }
    }
}
