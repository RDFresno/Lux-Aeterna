﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMiniMap : MonoBehaviour 
{
	public Transform playerTransform;
	void Update () 
	{
		transform.position = new Vector3 (playerTransform.position.x, transform.position.y, playerTransform.position.z);
	}
}
