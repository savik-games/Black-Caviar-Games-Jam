﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;
using yaSingleton;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "GameManager", menuName = "Singletons/GameManager")]
public class GameManager : Singleton<GameManager> {
	public MouseTooltip tooltip;
	public Game game;

	protected override void Initialize() {
		base.Initialize();
	}

	protected override void Deinitialize() {
		base.Deinitialize();
	}
}
