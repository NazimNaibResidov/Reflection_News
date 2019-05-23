using InterfaceProtocol;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using System.Windows.Forms;

namespace XmlConverter
{
    public class Converter : IProvider
    {
        
       

        public string Name()
        {
            return "Xml Converter";
        }

        public void OnButtonClick()
        {
          var data=  new SqlConnection("Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True");
           
          
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Products", data);
            data.Open();
            DataSet dat = new DataSet();
            adapter.Fill(dat);
            dat.WriteXml(Path.Combine(@"C:\Users\resid\source\repos\Reflections\ReflectionAppUI\bin\Debug\", "Main.Xml"));
            MessageBox.Show("Bank OfConverter");

        }
    }
}
