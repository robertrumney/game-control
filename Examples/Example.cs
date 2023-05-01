using UnityEngine;

public class MyScript : MonoBehaviour
{
    void Update()
    {
        if (GameControl.paused)
        {
            // Do something when the game is paused
        }
        else
        {
            // Do something else when the game is not paused
        }
    }
}
