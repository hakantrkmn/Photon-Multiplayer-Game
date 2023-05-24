using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateRoomButton : MonoBehaviour
{
    public TMP_InputField inputField;


    public void CreateRoom()
    {
        EventManager.CreateRoomButtonClicked(inputField.text);
    }
}
