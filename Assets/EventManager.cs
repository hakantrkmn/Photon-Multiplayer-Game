using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
   public static Action<MenuTypes> OpenMenu;
   public static Action<string> CreateRoomButtonClicked;
   public static Action<string> RoomFailed;
   public static Action LeaveRoomButtonCliced;

}
