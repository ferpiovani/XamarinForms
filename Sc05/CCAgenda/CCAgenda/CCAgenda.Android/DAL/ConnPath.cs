using System;
using CCAgenda.DAL;
using Xamarin.Forms;
using System.IO;

[assembly:Dependency(typeof(CCAgenda.Droid.DAL.ConnPath))]
namespace CCAgenda.Droid.DAL
{
    class ConnPath : IConnPath
    {
        public string getPath(string DBFileName)
        {
            var DirPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string DBPath = Path.Combine(DirPath, DBFileName);

            return DBPath;

            throw new NotImplementedException();
        }
    }
}