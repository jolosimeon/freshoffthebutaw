using UnityEngine;
using System.Collections;

public static class GameStats {

	private static int lastComplete, progress, currentLevel, lives, score;
	private static bool hasPassed;
	private static int[] levels = { 3, 4, 5, 6 };

	public static int LastComplete 
	{
		get 
		{
			return lastComplete;
		}
		set 
		{
			lastComplete = value;
		}
	}

	public static int Progress 
	{
		get 
		{
			return progress;
		}
		set 
		{
			progress = value;
		}
	}

	public static int CurrentLevel 
	{
		get 
		{
			return currentLevel;
		}
		set 
		{
			currentLevel = value;
		}
	}

	public static int[] Levels 
	{
		get 
		{
			return levels;
		}
		set 
		{
			levels = value;
		}
	}

	public static bool HasPassed 
	{
		get 
		{
			return hasPassed;
		}
		set 
		{
			hasPassed = value;
		}
	}

	public static int Lives 
	{
		get 
		{
			return lives;
		}
		set 
		{
			lives = value;
		}
	}

	public static int Score 
	{
		get 
		{
			return score;
		}
		set 
		{
			score = value;
		}
	}
}
