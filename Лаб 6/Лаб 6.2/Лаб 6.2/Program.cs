﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Лаб_6._2
{
    class Program
    {
        /// <summary>
        /// Проверка, что у свойства есть атрибут заданного типа
        /// </summary>
        /// <returns>Значение атрибута</returns>
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type
       attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;
            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
          
        {
                Result = true;
                attribute = isAttribute[0];
            }
            return Result;
        }

        static void Main(string[] args)
        {
            ForInspection obj = new ForInspection();
            Type t = obj.GetType();
            Console.WriteLine("\nИнформация о типе:");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);
            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            { Console.WriteLine(x); }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            { Console.WriteLine(x); }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            { Console.WriteLine(x); }
            Console.WriteLine("\nПоля данных (public):");
            foreach (var x in t.GetFields())
            { Console.WriteLine(x); }
            Console.WriteLine("\nForInspection реализует IComparable -> " + t.GetInterfaces().Contains(typeof(IComparable)));
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("\nВызов метода:");
            //Создание объекта
            //ForInspection fi = new ForInspection();

            //Можно создать объект через рефлексию
            ForInspection fi = (ForInspection)t.InvokeMember(null,
           BindingFlags.CreateInstance, null, null, new object[] { });
            //Параметры вызова метода
            object[] parameters = new object[] { 3, 2 };

            //Вызов метода
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod,
           null, fi, parameters);
            Console.WriteLine("Plus(3,2)={0}", Result);
            Console.ReadLine();
        }
    }
    /// <summary> 
    /// Класс для исследования с помощью рефлексии 
    /// </summary>
    public class ForInspection : IComparable
    {
        public ForInspection() { }
        public ForInspection(int i) { }
        public ForInspection(string str) { }
        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }
        [NewAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;
        public int property2 { get; set; }
        [NewAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }
        public int field1;
        public float field2;
        /// <summary> 
        /// Реализация интерфейса IComparable 
        /// </summary> 
        public int CompareTo(object obj) { return 0; }
    }
    /// <summary>
    /// Класс атрибута
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false,
   Inherited = false)]
    public class NewAttribute : Attribute
    {
        public NewAttribute() { }
        public NewAttribute(string DescriptionParam)
        {
            Description = DescriptionParam;
        }
        public string Description { get; set; }
    }

}


