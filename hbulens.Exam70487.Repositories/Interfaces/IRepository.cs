﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hbulens.Exam70487.Repositories
{
    /// <summary>
    /// Common data access interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IReadRepository<T>, ICreateRepository<T>, IEditRepository<T>, IDeleteRepository<T>
    {
    }
}
