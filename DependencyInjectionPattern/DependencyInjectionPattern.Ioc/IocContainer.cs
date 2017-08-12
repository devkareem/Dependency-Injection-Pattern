using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Ioc
{
   public class IocContainer
    {
        private readonly Dictionary<Type, Type> _iocDictionary = new Dictionary<Type, Type>();

        public void Registar<TFrom,TTo>()
        {
            _iocDictionary[typeof(TFrom)] = typeof(TTo);
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }
        public object Resolve(Type from)
        {
            if (!_iocDictionary.ContainsKey(from))
                throw new Exception($"The type {from.Name} can't be resolved, It is not registared");

            var to = _iocDictionary[from];
            var cInfo = to.GetConstructors().First();

            return (!cInfo.GetParameters().Any()) ? Activator.CreateInstance(to) : cInfo.Invoke(cInfo.GetParameters().Select(parameter=>Resolve(parameter.ParameterType)).ToArray());
        }
    }
}
