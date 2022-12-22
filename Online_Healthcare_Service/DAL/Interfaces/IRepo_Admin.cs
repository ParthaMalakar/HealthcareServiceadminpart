﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo_Admin<CLASS, ID>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        bool Create(CLASS obj);
        bool Update(CLASS obj);
        bool Delete(ID id);

    }
}
