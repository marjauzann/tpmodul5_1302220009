﻿using System;

class Program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo user " + inputUser);
        }
    }
    public class DataGeneric<T>
    {
        T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    static void Main(string[] args)
    {
        String nama = "Marjauza Naswansyah";
        HaloGeneric sapaObj = new HaloGeneric();
        sapaObj.SapaUser(nama);
        Console.WriteLine();

        DataGeneric<string> dataObj = new DataGeneric<string>("1302220009");
        dataObj.PrintData();
    }
    
}