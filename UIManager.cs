using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject startPannel;
    [SerializeField] GameObject gamePannel;

    void ShowPannel(GameObject panelToShow)
    {
        startPannel.SetActive(false);
        gamePannel.SetActive(false);

        panelToShow.SetActive(true);
    }

    public void OnClickStartButton()
    {
        ShowPannel(gamePannel);
        GamePlayManager.instance.StartSpawningTarget();
    }
}
