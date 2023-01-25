using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Entites
{
    public sealed class ServiceLifetimeReporter
    {
  
        private readonly IScopedService _scopedService;
        private readonly IRepository _repository;

        public ServiceLifetimeReporter(IScopedService scopedService, IRepository repository ) => 
            (_scopedService,_repository) = (scopedService,repository);


        public void ReportServiceLifetimeDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);

            //LogService(_transientService, "Always different");
            LogService(_scopedService, "Changes only with lifetime",_scopedService.message);
            LogService(_repository, "instance de repository only with lifeTime",_repository.message);
            //LogService(_singletonService, "Always the same");
        }

        private static void LogService<T>(T service, string message,string info)
            where T : IReporterServiceLifeTime =>
            Console.WriteLine($" {typeof(T).Name}: {service.id} ({message}) : information {service.message}");


    }
}
