using UnityEngine;
using System.Collections;

public static class GameStats {

	private static int lastComplete, progress, currentLevel, lives, score, healthState;
	private static bool hasPassed;
	private static int[] levels = { 3, 4, 5, 6 };
    private static string[] bio = { "apple", "banana" };
    private static string[] nonbio = { "plasticbag", "chips", "bottle", "can" };

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


    public static string[] Bio
    {
        get
        {
            return bio;
        }
        set
        {
            bio = value;
        }
    }

    public static string[] Nonbio
    {
        get
        {
            return nonbio;
        }
        set
        {
            nonbio = value;
        }
    }

	public static int HealthState 
	{
		get 
		{
			return healthState;
		}
		set 
		{
			healthState = value;
		}
	}
}
