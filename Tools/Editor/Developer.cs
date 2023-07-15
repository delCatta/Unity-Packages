using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



namespace delcatta
{
    public class Developer
    {
        [MenuItem("Developer/Clear Saves")]
        public static void ClearSaves()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
