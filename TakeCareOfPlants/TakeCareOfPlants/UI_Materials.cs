using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class UI_Materials : UserControl
    {
        private static UI_Materials uiMaterials;

        public static UI_Materials Instance
        {
            get {
                if (uiMaterials == null) {
                    uiMaterials = new UI_Materials();
                }
                return uiMaterials;
            }
        }
        public UI_Materials()
        {
            InitializeComponent();
        }
    }
}
