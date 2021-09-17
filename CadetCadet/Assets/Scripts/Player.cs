using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError(collision.name);
    }

    void MovePlayer()
    {
        List<int> currentDirections = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            if(InputManager.instance.Direction[i])
            {
                currentDirections.Add(i);
            }
        }

       if(currentDirections.Count > 0)
       {
            foreach (int v in currentDirections)
            {
                switch (v)
                {
                    case 0:
                        gameObject.transform.Translate(Vector2.up * moveSpeed);
                        break;
                    case 1:
                        gameObject.transform.Translate(Vector2.left * moveSpeed);
                        break;
                    case 2:
                        gameObject.transform.Translate(Vector2.down * moveSpeed);
                        break;
                    case 3:
                        gameObject.transform.Translate(Vector2.right * moveSpeed);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
