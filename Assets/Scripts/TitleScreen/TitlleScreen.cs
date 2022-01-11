using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitlleScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nick;
    [SerializeField] TextMeshProUGUI gunChoice;
    [SerializeField] GameObject min;
    

    
    
    public void GunChoice()
    {
        if (gunChoice.text == "Light Gun")
        {
            MenuManager.Instance.gunNr = 1;
        }
        else if (gunChoice.text == ("Mid Gun"))
        {
            MenuManager.Instance.gunNr = 2;
        }
    }
    
    public void EnterName()
    {
        if (Nick.text.Length < 6)
        {
            min.SetActive(true);
        }
        else
        {
            min.SetActive(false);
            MenuManager.Instance.playerName =Nick.text;
        }
    }
    public void FightButton()
    {
        if(MenuManager.Instance.playerName.Length>5)
        {
            SceneManager.LoadScene(1);
        }
    }
   
    private void Update()
    {
        GunChoice();
        
    }


}
