﻿using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[AddComponentMenu("Playground/Actions/Consume Resource")]
[HelpURL("https://bit.ly/3wHzO6y")]
public class ConsumeResourceAction : Action
{
    [Header("Resource")]
    public int checkFor = 0;
    public int amountNeeded = 1;

    private UIScript userInterface;

    private void Start()
    {
        // Find the UI in the scene and store a reference for later use
        userInterface = GameObject.FindObjectOfType<UIScript>();
    }

    public override bool ExecuteAction(GameObject dataObject)
    {
        if (userInterface != null)
        {
            bool hasEnoughResource = userInterface.CheckIfHasResources(checkFor, amountNeeded);

            if (hasEnoughResource)
            {
                //consume the resource and update the UI
                //リソースを消費してUIを更新する
                userInterface.ConsumeResource(checkFor, amountNeeded);
            }

            return hasEnoughResource;
        }
        else
        {
            //Debug.LogWarning("User Interface prefab has not been found in the scene. The action can't execute!");
            Debug.LogWarning("UserInterface がシーン内にないので、この Action は実行できません。");
            return false;
        }
    }
}
