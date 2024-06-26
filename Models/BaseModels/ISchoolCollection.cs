﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models.BaseModels
{
    internal interface ISchoolCollection<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
