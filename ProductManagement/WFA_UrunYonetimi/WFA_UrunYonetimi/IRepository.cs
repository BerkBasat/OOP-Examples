using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public interface IRepository
    {
        //Add
        string Add();

        //Update
        string Update();

        //Delete
        string Delete();

        //List
        List<Urun> List();
    }
}
