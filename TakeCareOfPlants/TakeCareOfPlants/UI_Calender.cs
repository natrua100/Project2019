using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class UI_Calender : UserControl
    {
        private static UI_Calender uiCalender;

        public static UI_Calender Instance
        {
            get {
                if (uiCalender == null) {
                    uiCalender = new UI_Calender();
                }
                return uiCalender;
            }
        }
        public UI_Calender()
        {
            InitializeComponent();
        }
    }
}
