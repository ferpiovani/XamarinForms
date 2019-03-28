using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DAL
{
    public interface IConnPath
    {
        string getPath(string DBFileName);
    }
}
