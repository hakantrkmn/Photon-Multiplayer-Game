using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public MenuTypes type;
    public CanvasGroup canvasGroup;
    [ShowIf("type",MenuTypes.ErrorMenu)] public TextMeshProUGUI errorText;
    [ShowIf("type",MenuTypes.RoomMenu)] public TextMeshProUGUI roomName;

    private void OnEnable()
    {
        EventManager.CreateRoomButtonClicked += roomName => { if (type == MenuTypes.RoomMenu) this.roomName.text = roomName; };
        EventManager.RoomFailed += err => errorText.text = err;
        EventManager.OpenMenu += types => { if (types == this.type) OpenMenu();else CloseMenu();};
    }

    private void OnDisable()
    {
        EventManager.CreateRoomButtonClicked -= roomName => { if (type == MenuTypes.RoomMenu) this.roomName.text = roomName; };
        EventManager.RoomFailed -= err => errorText.text = err;
        EventManager.OpenMenu -= types => { if (types == this.type) OpenMenu();else CloseMenu();};
    }

     void OpenMenu()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
    }

     void CloseMenu()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;


    }
}
