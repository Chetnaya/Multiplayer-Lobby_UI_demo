using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNavigation : MonoBehaviour
{
    public void Join()
    {
        SceneManager.LoadScene("Room Panel");
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Lobby");
    }
}
