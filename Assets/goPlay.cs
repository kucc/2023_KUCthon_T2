using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goPlay : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Main");

    }
}
