using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

namespace ClassLibrary3
{
    public class Class1
    {
        [CommandMethod("QS")]
        public void ShowMessage()
        {
            // Get the active document and editor
            myForm form = new myForm();
            form.Show();
        }
    }
}
