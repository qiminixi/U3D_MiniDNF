﻿using UnityEngine;
using System.Collections;

public class SceneManagerCity : SceneManagerBase {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void Init()
	{
		base.Init();
	}

	public override void StartScene()
	{
		UIManager.OpenPanel(EmPanelName.MainPanel);
    }
}
