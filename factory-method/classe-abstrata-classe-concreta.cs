using System;

public class Program {
    public static void Main (string[] args) {
        Console.WriteLine ("\nobj1");
        var obj1 = new ClasseFilha1 ();
        obj1.Imprimir ();

        Console.WriteLine ("\nobj2");
        var obj2 = new ClasseFilha2 ();
        obj2.Imprimir ();

        Console.WriteLine ("\nobj3");
        var obj3 = new ClasseFilha3 ();
        obj3.Imprimir ();

        Console.WriteLine ("\nobj4");
        var obj4 = new ClasseFilha4 ();
        obj4.Imprimir ();
    }
}

public abstract class ClasseMaeAbstrata {
    public abstract void Imprimir ();
}

public class ClasseFilha1 : ClasseMaeAbstrata {
    public override void Imprimir () =>
        Console.WriteLine ("ClasseFilha1");
}

public class ClasseMaeConcreta {
    public virtual void Imprimir () {
        Console.WriteLine ("ClasseMaeConcreta");
    }
}

public class ClasseFilha2 : ClasseMaeConcreta { }

public class ClasseFilha3 : ClasseMaeConcreta {
    public override void Imprimir () {
        base.Imprimir ();
        Console.WriteLine ("ClasseFilha3");
    }
}

public class ClasseMaeConcreta2 {
    public void Imprimir () =>
        Console.WriteLine ("ClasseMaeConcreta2");
}

public class ClasseFilha4 : ClasseMaeConcreta2 {
    public new void Imprimir () =>
        Console.WriteLine ("ClasseFilha4");
}