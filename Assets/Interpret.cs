using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpret : MonoBehaviour
{
	public float targetTimeUnit = 0.05f;
	float minimumDash = 2.0f;
	float minimumWord = 6.0f;

	public void Signal(float length)
	{
		if (length < targetTimeUnit * minimumDash)
		{
			SendMessage("Dot");
		}
		else if (length < targetTimeUnit * minimumWord)
		{
			SendMessage("Dash");
		}
	}

	public void Gap(float length)
	{
		if (length < targetTimeUnit * minimumDash)
		{
			SendMessage("CodeGap");
		}
		else if (length < targetTimeUnit * minimumWord)
		{
			SendMessage("LetterGap");
		}
		else if (length > targetTimeUnit * minimumWord)
		{
			SendMessage("WordGap");
		}
	}
}
