
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Pizza {

    public Pizza() {
    }

    public String name;

    /// <summary>
    /// @return
    /// </summary>
    public void Bake() {
        // TODO implement here
        Console.WriteLine("�決");
    }

    /// <summary>
    /// @return
    /// </summary>
    public void Box() {
        // TODO implement here
        Console.WriteLine("���");
    }

    /// <summary>
    /// @return
    /// </summary>
    public void Cut() {
        // TODO implement here
        Console.WriteLine("�п�");
    }

    /// <summary>
    /// @return
    /// </summary>
    public abstract void Prepare();
    //{
    //    // TODO implement here
    //    //Console.WriteLine("׼������");
    //}
}