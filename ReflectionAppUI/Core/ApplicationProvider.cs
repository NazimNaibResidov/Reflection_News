using InterfaceProtocol;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ReflectionAppUI.Core
{
    public  class ApplicationProvider
    {
        public readonly Control Control;
        private int _locationSizeX;
        private int _locationSizeY;
        public ApplicationProvider(Control Control)
        {
            this.Control = Control;
            DefaultParams();
        }
        private void DefaultParams()
        {
            this._locationSizeX = 30;
            this._locationSizeY = 30;
        }
        public void CleanData()
        {
            Control.Controls.Clear();
            DefaultParams();

        }
        public void AddButtonProvider(IProvider provider)
        {
            Button btn = new Button
            {
                Text = provider.Name(),
                Size = new Size(90,90),
                Location = new Point(this._locationSizeX, this._locationSizeY)
            };
               btn.Click +=(options,sender)=>
                {
                    provider.OnButtonClick();
                };
            this._locationSizeX += 100;
            this.Control.Controls.Add(btn);
        }
        public void Loader(string path)
        {
          string [] pathDll=  Directory.GetFiles(path,"*.dll");

            
           
            foreach (var item in pathDll)
            {
              Assembly asmbler=  Assembly.LoadFile(item);
               
              Type [] tips=  asmbler.GetTypes();
                foreach (Type ite in tips)
                {
                  Type tip=  ite.GetInterface("IProvider", true);
                    
                    if (tip!=null)
                    {
                       IProvider provider= (IProvider)Activator.CreateInstance(ite);
                        this.AddButtonProvider(provider);
                    }
                   
                }
            }
        }

      
    }
}
