using System.IO;
using UnityEngine;
using UnityEditor;
using static System.IO.Path;
using static System.IO.Directory;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;



namespace delcatta
{
    public class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            const string root = "_Project";
            Dir(root, "_Scripts", "Art", "Prefabs", "Scenes");
            Dir(Combine(root, "_Scripts"), "Scriptables", "Systems", "Units", "Utilities");
            Dir(Combine(root, "_Scripts", "Units"), "Enemies", "Heroes");
            Dir(Combine(root, "Art"), "Sprites", "UI");

            Refresh();
        }

        public static void Dir(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach (var newDirectory in dir)
            {
                CreateDirectory(Combine(fullPath, newDirectory));
            }
        }
    }
}
