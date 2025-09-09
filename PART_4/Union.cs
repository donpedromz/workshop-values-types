using System;

public enum VariantType {
    Integer,
    Floating,
    Text
}

public struct Variant {
    public VariantType Type;
    public int Integer;
    public float Floating;
    public string Text;
}

class VariantDemo {
    static void Main(string[] args) {
        Variant v = new Variant();
        v.Type = VariantType.Floating;
        v.Floating = 7.5f;
        if (v.Type == VariantType.Integer)
            Console.WriteLine($"Variant integer: {v.Integer}");
        else if (v.Type == VariantType.Floating)
            Console.WriteLine($"Variant floating: {v.Floating}");
        else if (v.Type == VariantType.Text)
            Console.WriteLine($"Variant text: {v.Text}");
    }
}
