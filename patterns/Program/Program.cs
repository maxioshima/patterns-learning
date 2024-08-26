using System;
using Norbit.Crm.Anoshkeen.AbstractFactory;
using Norbit.Crm.Anoshkeen.Observer;
using Norbit.Crm.Anoshkeen.Decorator;
using Norbit.Crm.Anoshkeen.Singleton;
using Norbit.Crm.Anoshkeen.Adapter;
using Norbit.Crm.Anoshkeen.Mediator;
using Norbit.Crm.Anoshkin.Iterator;
using System.Collections.Generic;
using System.Security.AccessControl;
using Norbit.Crm.Anoshkeen;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata;

namespace Norbit.Crm.Anoshkeen.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            try
            {
                GetMetadata();
                /*var borrowerDataList = GetTestData();
                var validator = new BorrowerInfoValidator();
                var counter = 0;

                foreach (var borrower in borrowerDataList)
                {
                    Console.WriteLine($"Borrower {counter}");
                    validator.Validate(new GeneralInfoValidator(), borrower);
                    Console.WriteLine("test");

                    Console.WriteLine("After checking the general information:");
                    Console.WriteLine(borrower.ToString());

                    validator.Validate(new CreditRisksInfoValidator(), borrower);

                    Console.WriteLine("After checking credit risks, the data is reset due to a validation error:");
                    Console.WriteLine(borrower.ToString());
                    Console.WriteLine();
                    counter++;
                }*/
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetMetadata() {
            using (var fs = new FileStream("Singleton.dll", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var peReader = new PEReader(fs)) 
            {
                MetadataReader mr = peReader.GetMetadataReader();

                foreach (TypeDefinitionHandle tdefh in mr.TypeDefinitions)
                {
                    TypeDefinition tdef = mr.GetTypeDefinition(tdefh);
                    string attributes = tdef.GetCustomAttributes().ToString();
                    string ns = mr.GetString(tdef.Namespace);
                    string name = mr.GetString(tdef.Name);
                    Console.WriteLine($"{ns}.{name}");
                }
            };
        }

        /// <summary>
        /// Получить тестовые данные.
        /// </summary>
        /// <returns>Список с тестовыми данными.</returns>
        public static List<Borrower> GetTestData()
        {
            var invalidBorrower = new Borrower() { };
            invalidBorrower.generalInfo.Age = 23;
            invalidBorrower.generalInfo.Name = "Oleg";
            invalidBorrower.generalInfo.FamilyName = "Petrov";
            invalidBorrower.generalInfo.MiddleName = "Alexandrovich";
            invalidBorrower.creditRisksInfo.RisksCm = 12;
            invalidBorrower.creditRisksInfo.RisksKm = 123;
            invalidBorrower.creditRisksInfo.NeedRisksInfoRecalculation = false;

            var normalBorrower = new Borrower() { };
            normalBorrower.generalInfo.Age = 18;
            normalBorrower.generalInfo.Name = "Max";
            normalBorrower.generalInfo.FamilyName = "Anoshkeen";
            normalBorrower.generalInfo.MiddleName = "Alexandrovich";
            normalBorrower.creditRisksInfo.RisksCm = 12;
            normalBorrower.creditRisksInfo.RisksKm = 43;
            normalBorrower.creditRisksInfo.NeedRisksInfoRecalculation = false;

            return new List<Borrower> { invalidBorrower, normalBorrower };
        }
    }
}
