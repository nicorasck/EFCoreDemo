﻿using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Security.Cryptography;

namespace EFCoreDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Lesson 1 - Entity FrameWork - week 47\n");
        Console.ForegroundColor = ConsoleColor.White;

        System.Console.WriteLine("What would you like to do?");
        System.Console.WriteLine("1. - Add data.");
        System.Console.WriteLine("2. - Read data.");

        var _input = Console.ReadLine();

        if (_input == "1")
        {
            AddData.Run();
        }
        else if (_input == "2")
        {
            ReadData.Run();
        }
        else
        {
            System.Console.WriteLine("Invalid input.");
        }
    }

}
