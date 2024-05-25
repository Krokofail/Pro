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

    public class Application
    {
        public Application(
            IOperationProvider operationProvider,
            IMenu menu)
        {
            this.operationProvider = operationProvider;
            this.menu = menu;
        }

        private IOperationProvider operationProvider;
        private IMenu menu;
        private IEnumerable<Operation> operations;

        public void Run()
        {
            operations = operationProvider.Get();
            Operation operation = menu.Show(operations.ToArray());
            operation.Run(10, 5);
        }
    }
    public abstract class Operation : IOperation
    {
        public Operation(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract double Run(params double[] numbers);
    }

    public sealed class Addition : Operation
    {
        public Addition() : base("Сложение")
        {

        }

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

    public sealed class Substraction : Operation
    {
        public Substraction() : base("Вычитание")
        {

        }

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
    }

    public sealed class Multiplacation : Operation
    {
        public Multiplacation() : base("Умножение")
        {

        }

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
    }

    public sealed class Division : Operation
    {
        public Division() : base("Деление")
        {

        }

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }

    public sealed class Sqrt : Operation
    {
        public Sqrt() : base("Квадратный корень")
        {

        }

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public sealed class Cos : Operation
    {
        public Cos() : base("Косинус")
        {

        }

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public sealed class Sin : Operation
    {
        public Sin() : base("Синус")
        {

        }

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

    public sealed class Tg : Operation
    {
        public Tg() : base("Тангенс")
        {

        }

        public override double Run(params double[] numbers)
        {
            return 0d;
        }
    }

}