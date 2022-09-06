using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetStarted : MonoBehaviour
{
    [SerializeField] private string GetStartedButton1 = "Question1";

    public void GetStartedButton()
    {
        SceneManager.LoadScene(GetStarted);
    }
}
