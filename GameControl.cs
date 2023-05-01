using UnityEngine;

public static class GameControl : object
{ 
    public static bool paused, inventory, cutscene, objectives, conversation, importantConversation, tutorial, gasMask, labcoat = true;
    public static bool inCar, thirdPerson, dead, vendor, bulletTime, inTank;
    public static bool fauna = true, wildlife = true, elements = true, aa = true, motionBlur = true;
    public static string currentSlot;
    public static int level, xp;
    public static int[] skills = new int[4];
    public static string saveName = "SLOT_1";

    public static GameObject player()
    {
        return GameObject.FindWithTag("Player");
    }

    public static void GetCurrentSlot()
    {
        currentSlot = PlayerPrefs.GetString("CurrentSlot");
    }

    public static void DebugLog()
    {
        Debug.Log("paused is " + paused);
        Debug.Log("inventory is " + inventory);
        Debug.Log("cutscene is " + cutscene);
        Debug.Log("objectives is " + objectives);
        Debug.Log("conversation is " + conversation);
        Debug.Log("tutorial is " + tutorial);
        Debug.Log("gasMask is " + gasMask);
        Debug.Log("inCar is " + inCar);
        Debug.Log("thirdPerson is " + thirdPerson);
    }
}
