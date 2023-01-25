using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Repository
{
    public interface IScopedService :IReporterServiceLifeTime
    {

        ServiceLifetime IReporterServiceLifeTime.Lifetime => ServiceLifetime.Scoped;
    }
}
