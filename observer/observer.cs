using System;
using System.Collections.Generic;
 
class MainClass {
  public static void Main() {
    Variable travelledDistance = new Variable("travelledDistance", 0);
    Component component1 = new Component() { Name = "First Component" };
    Component component2 = new Component() { Name = "Second Component" };
	
    travelledDistance.RegisterObserver(component1);
    Console.WriteLine($"{component1.Name} attached to {travelledDistance.Name}\n");
    travelledDistance.Value = 5;
	
    travelledDistance.RegisterObserver(component2);
    Console.WriteLine($"\n{component2.Name} attached to {travelledDistance.Name}\n");
	
    travelledDistance.Value = 20;
	
    travelledDistance.UnregisterObserver(component1);
    Console.WriteLine($"\n{component1.Name} detached from {travelledDistance.Name}\n");
	
    travelledDistance.Value = 50;
	
    travelledDistance.UnregisterObserver(component2);
    Console.WriteLine($"\n{component2.Name} detached from {travelledDistance.Name}\n");
	
    travelledDistance.Value = 95;
  }
}

interface IObserver  {
  void Notify(Subject subject);
}

abstract class Subject {
  private string _name;
  private double _value;
  private List<IObserver> _observers = new List<IObserver>();

  public Subject(string name, double value) {
    this._name = name;
    this._value = value;
  }

  public void RegisterObserver(IObserver observer) => _observers.Add(observer);

  public void UnregisterObserver(IObserver observer) => _observers.Remove(observer);

  public void NotifyObservers()
  {
    foreach (IObserver observer in _observers) {
      observer.Notify(this);
    }
  }

  public double Value {
    get => _value;
    set {
      if (_value != value) {
        _value = value;
        Console.WriteLine($"Changed {_name} value to: {value}");
        NotifyObservers();
      }
    }
  }

  public string Name => _name;
}

class Variable : Subject {
  public Variable(string name, double value) : base(name, value) => Console.WriteLine($"{name} created\n");
}

class Component : IObserver  {
  public void Notify(Subject subject) => Console.WriteLine($"Notified {Name} of new {subject.Name} value: {subject.Value}");

  public string Name { get; set; }
  public Subject Subject {
    get; set;
  }
}