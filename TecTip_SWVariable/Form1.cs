using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace TecTip_SWVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();

            ModelDoc2 modelDoc2 = swApp.ActiveDoc as ModelDoc2;
            ModelDocExtension ext = modelDoc2.Extension;
            CustomPropertyManager customPropertyManager = ext.get_CustomPropertyManager("Standard");
            customPropertyManager.Add3(
                TextBox_Create_Variable.Text, 
                (int)swCustomInfoType_e.swCustomInfoText, 
                "Peter", 
                (int)swCustomInfoAddResult_e.swCustomInfoAddResult_AddedOrChanged);
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();

            ModelDoc2 modelDoc2 = swApp.ActiveDoc as ModelDoc2;
            ModelDocExtension ext = modelDoc2.Extension;
            CustomPropertyManager customPropertyManager = ext.get_CustomPropertyManager("Standard");
            customPropertyManager.Get6(
                TextBox_Read_Variable.Text, 
                false, 
                out string Value, 
                out string Resolvedvalue, 
                out bool WasResolved, 
                out bool LinkToProperty);
            Label_Read_Value.Text = Resolvedvalue;
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();

            ModelDoc2 modelDoc2 = swApp.ActiveDoc as ModelDoc2;
            ModelDocExtension ext = modelDoc2.Extension;
            CustomPropertyManager customPropertyManager = ext.get_CustomPropertyManager("Standard");
            customPropertyManager.Set2(TextBox_Update_Variable.Text,TextBox_Update_Value.Text);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();

            ModelDoc2 modelDoc2 = swApp.ActiveDoc as ModelDoc2;
            ModelDocExtension ext = modelDoc2.Extension;
            CustomPropertyManager customPropertyManager = ext.get_CustomPropertyManager("Standard");
            customPropertyManager.Delete2(TextBox_Delete_Variable.Text);
        }
    }
}
