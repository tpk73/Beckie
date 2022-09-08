using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetStarted : MonoBehaviour
{
    [SerializeField] private void GetStartedButton = "Question1";

    public void GetStartedButton()
    {
        SceneManager.LoadScene(GetStarted)
    }
}