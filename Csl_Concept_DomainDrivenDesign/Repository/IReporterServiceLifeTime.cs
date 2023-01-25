using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Repository
{
    public interface IReporterServiceLifeTime
    {
         public Guid id { get;  }
         public ServiceLifetime Lifetime {  get; }  

        public string message { get; set; } 


    }
}
