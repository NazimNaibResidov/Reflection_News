using InterfaceProtocol;
using System.Windows.Forms;

namespace BankOfRespublica
{
    public class BankOfresp : IProvider
    {
        public string Name()
        {
            return "Bank Of Respublica";
        }

        public void OnButtonClick()
        {
            MessageBox.Show("Bank Of Respublica");
        }
    }
}
