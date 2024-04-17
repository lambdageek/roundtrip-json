// Foo

ReadOnlySpan<byte> content = File.ReadAllBytes(args[0]);
Console.WriteLine($"{content[0]:x} {content[1]:x}");

var res = ContractDescriptorParser.ParseCompact(content);

if (res is null)
{
        Console.Error.WriteLine ("could not parse json");
        return;
}

Console.WriteLine (res);


