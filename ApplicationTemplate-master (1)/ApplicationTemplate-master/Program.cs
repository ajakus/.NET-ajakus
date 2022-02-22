using System;
using System.Collections.Generic;
using ApplicationTemplate.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationTemplate;

public class Program
{
    static void Main(string[] args)
    {
        PetStore petStore = new PetStore();

        Console.WriteLine("Which animal do you want to hear?");

        Animal pig = new Pig();
        petStore.Animals.Add(pig);

        Animal dog = new Dog();
        petStore.Animals.Add(dog);

        Animal cat = new Cat();
        petStore.Animals.Add(cat);

        Animal bird = new Bird();
        petStore.Animals.Add(bird);

        Animal frog = new Frog();
        petStore.Animals.Add(frog);

        foreach (var animalA in petStore.Animals)
        {
            animalA.MakeNoise();
            animalA.Sleep();
        }
    }
}

public class PetStore
{
    public List<Animal> Animals { get; set; }
}
public abstract class Animal

    
{
    public string Name { get; set; }
    public abstract void MakeNoise();


    public virtual void Sleep()
    {
        Console.WriteLine("ZZZZZZZZZZZZZZZZZ");
    }
}
public class Pig : Animal
{
    public Pig()
    {
        Name = "oinki";
    }
    public  override void MakeNoise()
    {
        Console.WriteLine("Oink");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("ZZZ...ZzZ...zZz");
    }
}
public class Dog : Animal
{
    public Dog()
    {
        Name = "Barki";
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Bark");
    }
    public void Sleep()
    {
        Console.WriteLine("ZZZ...ZzZ...zZz");
    }
}
public class Cat : Animal
{
    public Cat()
    {
        Name = "meowy";
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Meow");
    }
    public void Sleep()
    {
        Console.WriteLine("ZZZ...ZzZ...zZz");
    }
}
public class Bird : Animal
{
    public Int32  NumberOfWings { get; set; }
    public Bird()
    {
        Name = "Birdi";
        NumberOfWings = 2;
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Squawk");
    }
    public void Sleep()
    {
        Console.WriteLine("ZZZ...ZzZ...zZz");
    }
}
public class Frog : Animal
{
    public Int32 NumberOfWings { get; set; }
    public Frog()
    {
        Name = "Kermit";
        NumberOfWings = 2;
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Ribbit");
    }
    public void Sleep()
    {
        Console.WriteLine("Crbrrbbr...grbrbrbbrrr...bereeeepebebebeep");
    }
}
