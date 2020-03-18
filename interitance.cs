using System;

public class Example
{
   public static void Main()
   {
      var child = new Child("Mertt");
	   child.writeName();
   }
}

public class Parent{
	public string Name;
	public Parent(string name){
		Console.WriteLine("Parent constructor - " + name);
		Name = name;
	}
	public void writeName(){
		Console.WriteLine(Name);
	}
}

public class Child : Parent {
	public Child(string name):base(name){
		Console.WriteLine("Child constructor - "+ name);
	}
}
