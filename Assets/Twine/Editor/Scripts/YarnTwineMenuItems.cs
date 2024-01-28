using UnityEditor;
using static CelesteEditor.Scene.MenuItemUtility;


namespace YarnEditor.Twine
{
   public static class MenuItems
   {
       [MenuItem(YarnTwineEditorConstants.SCENE_MENU_ITEM)]
       public static void LoadYarnTwineMenuItem()
       {
           LoadSceneSetMenuItem(YarnTwineEditorConstants.SCENE_SET_PATH);
       }
   }
}