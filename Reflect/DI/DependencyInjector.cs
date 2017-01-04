using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reflect.Context.UnitOfWork;
using StructureMap;

namespace Reflect.DI
{
    public class DependencyInjector
    {
        public void register_all_types_of_an_interface()
        {
            var container = new Container(_ =>
            {
                // The default visualizer just like we did above
                _.For(typeof(IUnitOfWork)).Use(typeof(OdelUnitOfWork));
            });
        }
    }
}