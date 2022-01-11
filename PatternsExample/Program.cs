// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using PatternsExample.adapter;
using PatternsExample.factory;
using PatternsExample.iterator;
using PatternsExample.singleton;
using PatternsExample.zombie;


Library library = new Library();
Reader reader = new Reader();
reader.SeeBook(library);


var logistic = new RoadLogistic();
logistic.PlanDelivery();


Database db = Database.GetInstance();
Database db1 = Database.GetInstance();

Console.WriteLine(db == db1);

ClientJava clientJava = new ClientJava();
var client = new Adapter(clientJava);
client.DoSomething();

ClassicZombie classicZombie = new ClassicZombie();
classicZombie.OnHold();

ClassicZombie classicZombie1 = new ClassicZombie();
classicZombie.OnHold();

List<ClassicZombie> list = null; 
list.Add(classicZombie);
list.Add(classicZombie1);

/*
ZombieSherrif zombieSherrif = new ZombieSherrif();
zombieSherrif.shoot();

Car car = new Car(classicZombie);
car.zombieDriver.OnHold();

Car car1 = new Car(zombieSherrif);
car1.zombieDriver.Walk();*/

Console.WriteLine("Hello, World!");