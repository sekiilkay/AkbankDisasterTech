﻿using ATOM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.Repositories
{
    public interface IWreckPopRepository : IGenericRepository<WreckPopulation>
    {
        Task Test(string districtName);
    }
}