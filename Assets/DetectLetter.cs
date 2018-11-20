using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLetter : MonoBehaviour
{
	string [] letters = new string [] 
	{
		". -",		// A
		"- . . .",	// B
		"- . - .",	// C
		"_ . .",	// D
		".",		// E
		". . - .",	// F
		"- - .",	// G
		". . . .",	// H
		". .",		// I
		". - - -",	// J
		"- . -",	// K
		". - . .",	// L
		"- -",		// M
		"- .",		// N
		"- - -",	// O
		". - - .",	// P
		"- - . -",	// Q
		". - .",	// R
		". . .",	// S
		"-",		// T
		". . -",	// U
		". . . -",	// V
		". - -",	// W
		"_ . . _",	// X
		"- . - -",	// Y
		"- - . .",	// Z
	};

	string current = "";

	void AddCode(string symbol)
	{
		current += symbol;
	}

	public void Dot()
	{
		AddCode(".");
	}

	public void CodeGap()
	{
		AddCode(" ");
	}

	public void Dash()
	{
		AddCode("-");
	}

	public void LetterGap()
	{
		for (int i = 0; i < letters.Length; ++i)
		{
			if (current == letters[i])
			{
				Debug.LogFormat("Detected {0} letter {1}", current, (char)('A' + i));
				break;
			}
		}
		current = "";
	}

	public void WordGap()
	{
		LetterGap();
	}
}
