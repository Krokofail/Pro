using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    public interface IOperationProvider
    {

        public IEnumerable<Operation> Get();
    }


    public sealed class OperationProvider : IOperationProvider
    {
        private IEnumerable<Operation> operations;

        public OperationProvider(IEnumerable<Operation> operations)
        {
            this.operations = operations;
        }

        public IEnumerable<Operation> Get()
        {
            return operations;
        }
    }
    public interface IMenu
    {
        public Operation Show(Operation[] operations);
    }

    public sealed class Menu : IMenu
    {
        public Operation Show(Operation[] operations)
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name};");
            }
            Console.Write("Выберите действие: ");
            return operations[Convert.ToInt32(Console.ReadLine()) - 1];
        }
    }

    public sealed class NewMenu : IMenu
    {
        public Operation Show(Operation[] operations)
        {
            Console.WriteLine("....КАЛЬКУЛЯТОР....");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. {operation.Name};");
            }
            Console.Write("Выберите действие: ");
            return operations[Convert.ToInt32(Console.ReadLine()) - 1];
        }
    }
    public sealed class Vibor
    {
        public void Vibor(Operation[] operations)
        {
            Console.Write("Выберите действие: ");
            return Operations(Convert.ToInt32(Console.ReadLine() - 1);
        }
    }
}

