using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Interfaces
{
    public interface IPlantsRepository
    {
        Task<List<Plant>> getwithIncludeAmount();
    }
}
