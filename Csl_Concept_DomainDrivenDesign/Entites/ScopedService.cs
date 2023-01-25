using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Entites
{
    internal class ScopedService : IScopedService
    {
        public string message { get; set; }

        Guid IReporterServiceLifeTime.id { get; } = Guid.NewGuid();
    }
}
