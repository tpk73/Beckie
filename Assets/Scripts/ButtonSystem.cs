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
    public GameObject m_porous;
    public GameObject m_semiporous;
    public GameObject m_nonporous; 

    

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
    public void Porous()
    {
        m_latent.SetActive(false);
        m_porous.SetActive(true);
    
    }
    public void SemiPorous()
    {
        m_latent.SetActive(false);
        m_semiporous.SetActive(true);

    }
    public void NonPorous()
    {
        m_latent.SetActive(false);
        m_nonporous.SetActive(true);
    
    }
    public void Back2fp()
    {
        m_latent.SetActive(false);
        m_fingerPrint.SetActive(true);    
    
    }
    public void Back2latent()
    {
        m_porous.SetActive(false);
        m_semiporous.SetActive(false);
        m_nonporous.SetActive(false);
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
