using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public ButtonTypes buttonTypes;


    public void ButtonClicked()
    {
        switch (buttonTypes)
        {
            case ButtonTypes.ErrorMenuLeaveButton:
                EventManager.OpenMenu(MenuTypes.TitleMenu);
                break;
            case ButtonTypes.CreateRoomMenuButton:
                EventManager.OpenMenu(MenuTypes.CreateRoomMenu);
                break;
            case ButtonTypes.LeaveRoomButton:
                EventManager.LeaveRoomButtonCliced();
                break;
        }
    }
}
