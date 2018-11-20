using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureSignal : MonoBehaviour
{
	float heldTime = 0.0f;
	float intervalTime = 0.0f;
	bool pressed = false;
	
	void Update()
	{
		bool previouslyPressed = pressed;
		pressed = Input.GetKey(KeyCode.Space);
		if (pressed)
		{
			heldTime += Time.deltaTime;
		}
		else
		{
			intervalTime += Time.deltaTime;
			if (intervalTime > 0.5f)
			{
				SendMessage("Gap", intervalTime);
				intervalTime = 0.0f;
			}
		}
		if (pressed != previouslyPressed)
		{
			if (previouslyPressed)
			{
				SendMessage("Signal", heldTime);
				heldTime = 0.0f;
			}
			else
			{
				SendMessage("Gap", intervalTime);
				intervalTime = 0.0f;
			}
		}
	}
}
