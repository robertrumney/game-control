using UnityEngine;

public static class GameControl : object 
{
	public static bool paused=false;
	public static bool inventory=false;
	public static bool cutscene=false;
	public static bool objectives=false;
	public static bool conversation=false;
	public static bool importantConversation=false;
	public static bool tutorial=false;
	public static bool gasMask=false;
	public static bool labcoat=true;
	public static bool inCar=false;
	public static bool thirdPerson=false;
	public static bool dead=false;
	public static bool vendor=false;
	public static bool bulletTime=false;
	public static bool inTank=false;
	public static string currentSlot;

	public static int level;
	public static int xp;
	public static int[] skills=new int[4];

	public static bool fauna=true;
	public static bool wildlife=true;
	public static bool elements=true;
	public static bool aa=true;
	public static bool motionBlur=true;

	public static string saveName="SLOT_NEW3";

	public static GameObject player()
	{
		GameObject x=GameObject.FindWithTag("Player");
		return x;
	}

	public static void GetCurrentSlot()
	{
		currentSlot=PlayerPrefs.GetString("CurrentSlot");
	}

	public static void DebugLog()
	{
		Debug.Log ( "paused is "+ paused);
		Debug.Log ( "inventory is "+inventory);
		Debug.Log ( "cutscene is "+cutscene);
		Debug.Log ( "objectives is "+ objectives);
		Debug.Log ( "conversation is "+conversation);
		Debug.Log ( "tutorial is "+ tutorial);
		Debug.Log ( "gasMask is " +gasMask);
		Debug.Log ( "inCar is "+ inCar);
		Debug.Log ( "thirdPerson is "+ thirdPerson);
	}
}
