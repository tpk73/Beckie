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
    public GameObject m_metal;
    public GameObject m_wood;
    public GameObject m_bpaplastic;
    public GameObject m_waxpaper;
    public GameObject m_tile;
    public GameObject m_CAFumingMetal;
    public GameObject m_CAFumingWood;
    public GameObject m_CAFumingBPAPlastic;
    public GameObject m_CAFumingWaxPaper;
    public GmaeObject m_CAFumingTile;
    

    public void GetStarted()
    {
        m_mainMenu.SetActive(false);
        m_fingerPrint.SetActive(true);
    }
    public void Metal()
    {
        m_nonporous.SetActive(false);
        m_metal.SetActive(true);    
    }
    public void CAFumingMetal()
    {
        m_metal.SetActive(false);
        m_CAFumingMetal.SetActive(true);
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
    public void Wood()   
    {
        m_nonporous.SetActive(false);
        m_Wood.SetActive(true);    
    }
    public void CAFumingWood()
    {
       m_Wood.SetActive(false);
       m_CAFumingWood.SetActive(true); 
    }
    public void BPAPlastic()
    {
        m_nonporous.SetActive(false);
        m_BPAPlastic.SetActive(true);
    }
    public void CAFumingBPAPlastic()
    {
       m_metal.SetActive(false);
       m_CAFumingBPAPlastic.SetActive(true);
    }
    public void WaxPaper()
    {
        m_nonporous.SetActive(false);
        m_waxpaper.SetActive(true);    
    }
    public void CAFumingWaxPaper()
    {
        m_metal.SetActive(false);
        m_CAFumingWaxPaper.SetActive(true);
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

