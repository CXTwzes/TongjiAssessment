using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Concrete;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public void AddBindings()
        {
            
            kernel.Bind<ICourseRepository>().To<DAOCourseRepository>();
            kernel.Bind<IInstructorRepository>().To<DAOInstructorRepository>();
            kernel.Bind<IPostRepository>().To<DAOPostRepository>();
            kernel.Bind<ICommentRepository>().To<DAOCommentRepository>();
            kernel.Bind<IFloorRepository>().To<DAOFloorRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}