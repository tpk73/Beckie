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
    public GameObject m_Wood;
    public GameObject m_BPAPlastic;
    public GameObject m_waxpaper;
    public GameObject m_tile;
    public GameObject m_CAFumingMetal;
    public GameObject m_CAFumingWood;
    public GameObject m_CAFumingBPAPlastic;
    public GameObject m_CAFumingWaxPaper;
    public GameObject m_CAFumingTile;
    public GameObject m_DyeTypesM;
    public GameObject m_R6GM;
    public GameObject m_ardroxM;
    public GameObject m_MBDM;
    public GameObject m_RAYM;
    public GameObject m_RAMM;
    public GameObject m_BasicY40M;
    public GameObject m_NileRedM;
    public GameObject m_PowderM;
    public GameObject m_PhysicalDeveloperM;
    public GameObject m_DyeTypesW;
    public GameObject m_R6GW;
    public GameObject m_ardroxW;
    public GameObject m_MBDW;
    public GameObject m_RAYW;
    public GameObject m_RAMW;
    public GameObject m_BasicY40W;
    public GameObject m_NileRedW;
    public GameObject m_PowderW;
    public GameObject m_PhysicalDeveloperW;
    public GameObject m_DyeTypesBPA;
    public GameObject m_R6GBPA;
    public GameObject m_ardroxBPA;
    public GameObject m_MBDBPA;
    public GameObject m_RAYBPA;
    public GameObject m_RAMBPA;
    public GameObject m_BasicY40BPA;
    public GameObject m_NileRedBPA;
    public GameObject m_PowderBPA;
    public GameObject m_PhysicalDeveloperBPA;
    public GameObject m_DyeTypesWP;
    public GameObject m_R6GWP;
    public GameObject m_ardroxWP;
    public GameObject m_MBDWP;
    public GameObject m_RAYWP;
    public GameObject m_RAMWP;
    public GameObject m_BasicY40WP;
    public GameObject m_NileRedWP;
    public GameObject m_PowderWP;
    public GameObject m_PhysicalDeveloperWP;
    public GameObject m_DyeTypesT;
    public GameObject m_R6GT;
    public GameObject m_ardroxT;
    public GameObject m_MBDT;
    public GameObject m_RAYT;
    public GameObject m_RAMT;
    public GameObject m_BasicY40T;
    public GameObject m_NileRedT;
    public GameObject m_PowderT;
    public GameObject m_PhysicalDeveloperT;


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
    public void DyeTypesM()
    {
        m_CAFumingMetal.SetActive(false);
        m_DyeTypesM.SetActive(true);
    }
    public void R6GM()
    {
        m_DyeTypesM.SetActive(false);
        m_R6GM.SetActive(true);
    }
    public void ardroxM()
    {
        m_DyeTypesM.SetActive(false);
        m_ardroxM.SetActive(true); 
    }
    public void MBDM()
    {
        m_DyeTypesM.SetActive(false);
        m_MBDM.SetActive(true);
    }
    public void RAYM()
    {
        m_DyeTypesM.SetActive(false);
        m_RAYM.SetActive(true);
    }
    public void RAMM()
    {
        m_DyeTypesM.SetActive(false);
        m_RAMM.SetActive(true);
    }
    public void BasicY40M()
    {
        m_DyeTypesM.SetActive(false);
        m_BasicY40M.SetActive(true);
    }
    public void NileRedM()
    {
        m_DyeTypesM.SetActive(false);
        m_NileRedM.SetActive(true);
    }
    public void PowderM()
    {
        m_DyeTypesM.SetActive(false);
        m_PowderM.SetActive(true);
    }
    public void PhysicalDeveloperM()
    {
        m_DyeTypesM.SetActive(false);
        m_PhysicalDeveloperM.SetActive(true);
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
    public void DyeTypesW()
    {
        m_CAFumingWood.SetActive(false);
        m_DyeTypesW.SetActive(true);
    }
    public void R6GW()
    {
        m_DyeTypesW.SetActive(false);
        m_R6GW.SetActive(true);
    }
    public void ardroxW()
    {
        m_DyeTypesW.SetActive(false);
        m_ardroxW.SetActive(true);
    }
    public void MBDW()
    {
        m_DyeTypesW.SetActive(false);
        m_MBDW.SetActive(true);
    }
    public void RAYW()
    {
        m_DyeTypesW.SetActive(false);
        m_RAYW.SetActive(true);
    }
    public void RAMW()
    {
        m_DyeTypesW.SetActive(false);
        m_RAMW.SetActive(true);
    }
    public void BasicY40W()
    {
        m_DyeTypesW.SetActive(false);
        m_BasicY40W.SetActive(true);
    }
    public void NileRedW()
    {
        m_DyeTypesW.SetActive(false);
        m_NileRedW.SetActive(true);
    }
    public void PowderW()
    {
        m_DyeTypesW.SetActive(false);
        m_PowderW.SetActive(true);
    }
    public void PhysicalDeveloperW()
    {
        m_DyeTypesW.SetActive(false);
        m_PhysicalDeveloperW.SetActive(true);
    }
    public void BPAPlastic()
    {
        m_nonporous.SetActive(false);
        m_BPAPlastic.SetActive(true);
    }
    public void CAFumingBPAPlastic()
    {
        m_BPAPlastic.SetActive(false);
        m_CAFumingBPAPlastic.SetActive(true);
    }
    public void DyeTypesBPA()
    {
        m_CAFumingBPAPlastic.SetActive(false);
        m_DyeTypesBPA.SetActive(true);
    }
    public void R6GBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_R6GBPA.SetActive(true);
    }
    public void ardroxBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_ardroxBPA.SetActive(true);
    }
    public void MBDBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_MBDBPA.SetActive(true);
    }
    public void RAYBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_RAYBPA.SetActive(true);
    }
    public void RAMBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_RAMBPA.SetActive(true);
    }
    public void BasicY40BPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_BasicY40BPA.SetActive(true);
    }
    public void NileRedBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_NileRedBPA.SetActive(true);
    }
    public void PowderBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_PowderBPA.SetActive(true);
    }
    public void PhysicalDeveloperBPA()
    {
        m_DyeTypesBPA.SetActive(false);
        m_PhysicalDeveloperBPA.SetActive(true);
    }
    public void WaxPaper()
    {
        m_nonporous.SetActive(false);
        m_waxpaper.SetActive(true);
    }
    public void CAFumingWaxPaper()
    {
        m_waxpaper.SetActive(false);
        m_CAFumingWaxPaper.SetActive(true);
    }
    public void DyeTypesWP()
    {
        m_CAFumingWaxPaper.SetActive(false);
        m_DyeTypesWP.SetActive(true);
    }
    public void R6GWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_R6GWP.SetActive(true);
    }
    public void ardroxWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_ardroxWP.SetActive(true);
    }
    public void MBDWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_MBDWP.SetActive(true);
    }
    public void RAYWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_RAYWP.SetActive(true);
    }
    public void RAMWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_RAMWP.SetActive(true);
    }
    public void BasicY40WP()
    {
        m_DyeTypesWP.SetActive(false);
        m_BasicY40WP.SetActive(true);
    }
    public void NileRedWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_NileRedWP.SetActive(true);
    }
    public void PowderWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_PowderWP.SetActive(true);
    }
    public void PhysicalDeveloperWP()
    {
        m_DyeTypesWP.SetActive(false);
        m_PhysicalDeveloperWP.SetActive(true);
    }
    public void tile()
    {
        m_nonporous.SetActive(false);
        m_tile.SetActive(true);
    }
    public void CAFumingTile()
    {
        m_tile.SetActive(true);
        m_CAFumingTile.SetActive(false);
    }
    public void DyeTypesT()
    {
        m_CAFumingTile.SetActive(false);
        m_DyeTypesT.SetActive(true);
    }
    public void R6GT()
    {
        m_DyeTypesT.SetActive(false);
        m_R6GT.SetActive(true);
    }
    public void ardroxT()
    {
        m_DyeTypesT.SetActive(false);
        m_ardroxT.SetActive(true);
    }
    public void MBDT()
    {
        m_DyeTypesT.SetActive(false);
        m_MBDT.SetActive(true);
    }
    public void RAYT()
    {
        m_DyeTypesT.SetActive(false);
        m_RAYT.SetActive(true);
    }
    public void RAMT()
    {
        m_DyeTypesT.SetActive(false);
        m_RAMT.SetActive(true);
    }
    public void BasicY40T()
    {
        m_DyeTypesT.SetActive(false);
        m_BasicY40T.SetActive(true);
    }
    public void NileRedT()
    {
        m_DyeTypesT.SetActive(false);
        m_NileRedT.SetActive(true);
    }
    public void PowderT()
    {
        m_DyeTypesT.SetActive(false);
        m_PowderT.SetActive(true);
    }
    public void PhysicalDeveloperT()
    {
        m_DyeTypesT.SetActive(false);
        m_PhysicalDeveloperT.SetActive(true);
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


