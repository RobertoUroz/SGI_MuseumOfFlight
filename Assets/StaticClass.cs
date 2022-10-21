using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticClass 
{
    public static string CrossSceneInformation = "F4F";

    public static Vector3 playerCoords = new Vector3(-225.64f, 1.6f, -1.99f);

    public static Quaternion playerOrientation = Quaternion.LookRotation(new Vector3(-225.64f, 1.6f, -1.99f) - new Vector3(-225.64f, 1.6f, 0), Vector3.up);

    public static bool exploreMode = false;
}
