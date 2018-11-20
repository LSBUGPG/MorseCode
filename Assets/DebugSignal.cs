using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSignal : MonoBehaviour
{
	public void Signal(float length)
	{
		Debug.LogFormat("Signal held for {0} seconds", length);
	}

	public void Gap(float length)
	{
		Debug.LogFormat("Gap for {0} seconds", length);
	}
}
