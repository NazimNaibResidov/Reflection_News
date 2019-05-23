using System.IO;

namespace ReflectionAppUI.Core
{
    public class Tools
    {
        private static string PathMain=@"C:\Users\resid\source\repos\Reflections";
        private static string PathLibs= @"C:\Users\resid\source\repos\Reflections\ReflectionAppUI\libs\";
        public static void Copy(string FolderName="")
        {
            DirectoryInfo Info = new DirectoryInfo(PathMain);
           
            FileInfo[] allFiles = Info.GetFiles("*.dll", SearchOption.AllDirectories);
          

            foreach (var file in allFiles)
            {
              
               
                if (file.Name != "InterfaceProtocol.dll")
                   if(!File.Exists(Path.Combine(PathLibs,file.Name)))
                    {
                        file.CopyTo(Path.Combine(PathLibs, file.Name));
                    }
                  
                   
            }
        }
    }
}
