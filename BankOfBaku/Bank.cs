using InterfaceProtocol;
using System.Windows.Forms;

namespace BankOfBaku
{
    public class Bank : IProvider
    {
        public string Name()
        {
            return "Ban Of Baku";
        }

        public void OnButtonClick()
        {
            MessageBox.Show("Bank Of Baku");
        }
    }
}
