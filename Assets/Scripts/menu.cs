using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // function click for the button
    public void button_click()
    {
        SceneManager.LoadScene(1);
    }
}
