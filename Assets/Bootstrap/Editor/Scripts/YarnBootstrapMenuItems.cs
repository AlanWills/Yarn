using UnityEditor;
using static CelesteEditor.Scene.MenuItemUtility;


namespace YarnEditor.Bootstrap
{
   public static class MenuItems
   {
       [MenuItem(YarnBootstrapEditorConstants.SCENE_MENU_ITEM)]
       public static void LoadYarnBootstrapMenuItem()
       {
           LoadSceneSetMenuItem(YarnBootstrapEditorConstants.SCENE_SET_PATH);
       }
   }
}