using UnityEditor;
using static CelesteEditor.Scene.MenuItemUtility;


namespace YarnEditor.Startup
{
   public static class MenuItems
   {
       [MenuItem(YarnStartupEditorConstants.SCENE_MENU_ITEM)]
       public static void LoadYarnStartupMenuItem()
       {
           LoadSceneSetMenuItem(YarnStartupEditorConstants.SCENE_SET_PATH);
       }
   }
}