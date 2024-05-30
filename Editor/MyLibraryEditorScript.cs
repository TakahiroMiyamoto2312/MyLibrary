using UnityEditor;

namespace MyLibrary
{
    [CustomEditor(typeof(MyLibraryRuntimeScript))]
    public class MyLibraryEditorScript : Editor
    {
        public override void OnInspectorGUI()
        {
            // Your editor code here
        }
    }
}