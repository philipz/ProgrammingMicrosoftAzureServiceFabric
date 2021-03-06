﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace CountryActor.Interfaces
{
    public interface ICountryActor : IActor
    {
        Task<List<Tuple<string, long>>> CountCountrySalesAsync();
    }
}