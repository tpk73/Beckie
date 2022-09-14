using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSystem : MonoBehaviour
{
    public GameObject m_mainMenu;
    public GameObject m_fingerPrint;
    public GameObject m_latent;
    public GameObject m_patent;
    public GameObject m_plastic;


    public void GetStarted()
    {
        m_mainMenu.SetActive(false);
        m_fingerPrint.SetActive(true);
    }

    public void Latent()
    {
        m_fingerPrint.SetActive(false);
        m_latent.SetActive(true);
    }
    public void Patent()
    {
        m_fingerPrint.SetActive(false);
        m_patent.SetActive(true);
    }
    public void Plastic()
    {
        m_fingerPrint.SetActive(false);
        m_plastic.SetActive(true);
    }

    public void ReturnToMenu()
    {
        m_fingerPrint.SetActive(false);
        m_mainMenu.SetActive(true); 
    }

    public void Quit()
    {
        Application.Quit();
    }
}
